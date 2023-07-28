using FluentResults;
using MarianaTestes.Aplicacao.ModuloTeste;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.SqlServer.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;



namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        IRepositorioTeste repositorioTeste;

        IRepositorioQuestao repositorioQuestao;

        IRepositorioMateria repositorioMateria;

        IRepositorioDisciplina repositorioDisciplina;

        TabelaTesteControl? TabelaTeste;

        ServicoTeste servicoTeste;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao, ServicoTeste servicoTeste)
        {
            this.repositorioTeste = repositorioTeste;

            this.repositorioMateria = repositorioMateria;

            this.repositorioQuestao = repositorioQuestao;

            this.repositorioDisciplina = repositorioDisciplina;

            this.servicoTeste = servicoTeste;

            ConfigurarTela();
        }

        public override void ConfigurarTela()
        {
            Configuracao ??= new Configuracao("Inserir Teste", "Editar Teste", "Excluir Teste")
            {
                BtnDetalhesEnabled = true,
                ToolTipDetalhes = "Detalhes Teste",
                BtnDuplicarEnabled = true,
                ToolTipDuplicar = "Duplicar Teste",
                BtnEditarEnabled = false,
                ToolTipEditar = "",
                BtnFiltrarEnabled = true,
                ToolTipFiltrar = "Filtrar Testes",
                BtnGerarPdfEnable = true,
                ToolTipGerarPdf = "Gerar PDF"
            };

        }
        public override void Inserir()
        {
            ApresentarTelaTesteForm();
        }

        public void DuplicarTeste()
        {
            int idTeste = TabelaTeste!.ObterIdTesteSelecionado();

            if (idTeste == -1) return;

            Teste teste = repositorioTeste.SelecionarPorId(idTeste);

            ApresentarTelaTesteForm(teste);
        }


        public override void Excluir()
        {
            int idTeste = TabelaTeste!.ObterIdTesteSelecionado();

            if (idTeste == -1) return;

            Teste teste = repositorioTeste.BuscarPorId(idTeste);

            DialogResult opcao = MessageBox.Show($"Confirma excluir o teste {idTeste} ?", "Excluir teste", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
               Result result =  servicoTeste.Excluir(teste);

                if(result.IsFailed)
                {
                    TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape(result.Errors[0].Message);
                }
                else
                {
                    AtualizarListagem();
                }
            }
        }

        public override void ObterDetalhes()
        {
            int id = TabelaTeste!.ObterIdTesteSelecionado();

            if (id == -1) return;

            Teste teste = repositorioTeste.SelecionarPorId(id,true,true,true);

            TelaDetalhesTeste telaDetalhe = new TelaDetalhesTeste(teste);

            telaDetalhe.ShowDialog();

        }

        public override void AtualizarListagem()
        {
            List<Teste> testes = repositorioTeste.BuscarTodos(true);

            TabelaTeste!.AtualizarLista(testes);

            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(testes.Count == 0 ? "Nenhum Teste Cadastrado Até o Momento!" : testes.Count == 1 ? "Exibindo 1 Teste" : $"Exibindo {testes.Count} Testes.");
        }

        public override UserControl ObterListagem()
        {
            TabelaTeste ??= new TabelaTesteControl();

            AtualizarListagem();

            return TabelaTeste;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Filtrar()
        {
            TelaFiltrarTesteForm telaFiltro = new TelaFiltrarTesteForm();

            telaFiltro.onEnviarTipoDeFiltro += BuscarOpcaoSelecionada;

            DialogResult dialog = telaFiltro.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                FiltroTeste filtro = telaFiltro.filtroTeste;

                List<Teste> testes = repositorioTeste.FiltrarTestes(filtro);

                TabelaTeste!.AtualizarLista(testes);

                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(testes.Count == 0 ? "Nenhum Teste Cadastrado Até o Momento!" : testes.Count == 1 ? "Exibindo 1 Teste" : $"Exibindo {testes.Count} Testes.");
            }
        }

        public void GerarPdfTesteCadastrado()
        {
            int id = TabelaTeste.ObterIdTesteSelecionado();

            if (id == -1) return;

            Teste teste = repositorioTeste.BuscarPorId(id);

            ApresentarPdf(teste);
        }

        private object BuscarOpcaoSelecionada(FiltroDeTeste filtro)
        {
            switch (filtro)
            {
                case FiltroDeTeste.Materia:
                    return repositorioMateria.BuscarTodos();

                case FiltroDeTeste.Disciplina:
                    return repositorioDisciplina.BuscarTodos();

                default: return null!;
            }
        }

        private Materia ObterMateriaCompleta(Materia materia)
        {
            return repositorioMateria.BuscarQuestoesDaMateria(materia);
        }

        private Disciplina ObterDisciplinaCompleta(Disciplina disciplina)
        {
            return repositorioDisciplina.BuscarPorId(disciplina.Id, true);
        }

        private List<Questao> ObterQuestoesRecuperacao(Disciplina disciplina, SerieMateriaEnum serie)
        {
            return repositorioQuestao.BuscarQuestoesProvaRecuperacao(disciplina.Id, serie);
        }

        private DialogResult EnviarMensagemSucesso()
        {
            return MessageBox.Show("Deseja gerar PDF?", "Gerar Pdf", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ApresentarTelaTesteForm(Teste testeExistente = null!)
        {
            List<Disciplina> disciplinas = repositorioDisciplina.BuscarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(disciplinas, new());

            telaTeste.onObterMateriasDisciplina_ += ObterDisciplinaCompleta;

            telaTeste.onObterQuestoesMateria_ += ObterMateriaCompleta;

            telaTeste.onObterDisciplinaESerie_ += ObterQuestoesRecuperacao;

            telaTeste.onGravarRegistro_ += servicoTeste.Inserir;

            if (testeExistente != null)
            {
                telaTeste.Teste = testeExistente;
                telaTeste.Text = "Duplicar Teste";
            }

            DialogResult dialogResult = telaTeste.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AtualizarListagem();

                ApresentarPdf(telaTeste.Teste);
            }
        }

        private void ApresentarPdf(Teste teste)
        {
            DialogResult dialog = EnviarMensagemSucesso();

            if (dialog == DialogResult.Yes)
            {
                TelaTestePdfForm telaPdf = new TelaTestePdfForm(teste);

                telaPdf.onVisualizarPdf += MostrarPdf;

                DialogResult result = telaPdf.ShowDialog();

                if(result == DialogResult.OK)
                {
                    string? caminho = telaPdf.Diretorio;

                    IGeradorDePdf gerador = new GeradorDePdf(caminho);

                    gerador.GerarPDF(teste);

                    gerador.GerarPDF(teste, gabarito: true);

                }
            }
        }

        private void MostrarPdf(Teste teste)
        {
            var telaDetalhes = new TelaDetalhesTeste(teste);

            telaDetalhes.ShowDialog();
        }

       
    }
}
