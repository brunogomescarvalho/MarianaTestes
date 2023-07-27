using FluentResults;
using MarianaTestes.Aplicacao.ModuloQuestao;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        IRepositorioQuestao repositorioQuestao;

        IRepositorioMateria repositorioMateria;

        TabelaQuestaoControl tabelaQuestao;

        ServicoQuestao servicoQuestao;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, ServicoQuestao servicoQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;

            this.repositorioMateria = repositorioMateria;

            this.servicoQuestao = servicoQuestao;

            ConfigurarTela();
        }

        public override void Inserir()
        {
            List<Materia> materias = repositorioMateria.BuscarTodos();

            TelaQuestaoForm telaQuestaoForm = new TelaQuestaoForm(materias);

            telaQuestaoForm._onGravarRegistro += servicoQuestao.Inserir;

            DialogResult dialog = telaQuestaoForm.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                AtualizarListagem();
            }
        }

        public override void Editar()
        {
            int idQuestao = tabelaQuestao!.BuscarIdQuestaoSelecionada();

            if (idQuestao == -1) return;

            Questao questao = repositorioQuestao.BuscarPorId(idQuestao);

            DialogResult opcao = MessageBox.Show($"Confima editar a questão {questao.Id} ?", "Editar questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                List<Materia> materias = repositorioMateria.BuscarTodos();

                TelaQuestaoForm telaQuestao = new TelaQuestaoForm(materias)
                {
                    Text = "Editar Questão",

                    Questao = questao
                };

                telaQuestao._onGravarRegistro += servicoQuestao.Editar;

                DialogResult dialog = telaQuestao.ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    AtualizarListagem();
                };

            }
        }

        public override void Excluir()
        {
            int idQuestao = tabelaQuestao!.BuscarIdQuestaoSelecionada();

            if (idQuestao == -1) return;

            Questao questao = repositorioQuestao.BuscarPorId(idQuestao);

            DialogResult opcao = MessageBox.Show($"Confima excluir a questão {questao.Id} ?", "Excluir questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                Result result = servicoQuestao.Excluir(questao);

                if (result.IsFailed)
                {
                    MessageBox.Show(result.Errors[0].Message, "Excluir Questão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }

            }
        }


        public override void ObterDetalhes()
        {
            int idQuestao = tabelaQuestao.BuscarIdQuestaoSelecionada();

            if (idQuestao == -1) return;

            Questao questao = repositorioQuestao.BuscarPorId(idQuestao);

            TelaDetalhesQuestaoForm telaDetalhes = new TelaDetalhesQuestaoForm(questao)

            { Text = "Detalhes Questão" };

            telaDetalhes.ShowDialog();
        }

        public override void Filtrar()
        {
            if (tabelaQuestao.TabelaVazia()) return;

            List<Materia> materias = repositorioMateria.BuscarTodos();

            TelaFiltrarQuestoesForm telaFiltrar = new TelaFiltrarQuestoesForm(materias)
            {
                Text = "Filtrar Questões"
            };

            if (telaFiltrar.ShowDialog() == DialogResult.OK)
            {
                List<Questao> registros = null!;

                FiltroDeQuestao filtro = telaFiltrar.filtro;

                switch (filtro)
                {
                    case FiltroDeQuestao.Todas:
                        registros = repositorioQuestao.BuscarTodos();
                        break;
                    case FiltroDeQuestao.Materia:
                        registros = repositorioQuestao.FiltrarQuestoesPorMateria(telaFiltrar.Materia);
                        break;
                    case FiltroDeQuestao.NaoUtilizadas:
                        registros = repositorioQuestao.BuscarQuestoesNaoUtilizadas();
                        break;
                }

                tabelaQuestao.AtualizarLista(registros);

                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(registros.Count == 0 ? "Nenhuma Questão cadastrada até o momento!" : registros.Count == 1 ? "Exibindo 1 Questão" : $"Exibindo {registros.Count} Questões.");
            }
        }




        public override void AtualizarListagem()
        {
            var registros = repositorioQuestao.BuscarTodos();

            tabelaQuestao.AtualizarLista(registros);

            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(registros.Count == 0 ? "Nenhuma Questão cadastrada até o momento!" : registros.Count == 1 ? "Exibindo 1 Questão" : $"Exibindo {registros.Count} Questões.");
        }
        public override void ConfigurarTela()
        {
            Configuracao ??= new Configuracao("Inserir Questão", "Editar Questão", "Excluir Questão")
            {
                BtnFiltrarEnabled = true,
                ToolTipFiltrar = "Filtrar Questoes",
                BtnDetalhesEnabled = true,
                ToolTipDetalhes = "Exibir Detalhes"
            };
        }

        public override UserControl ObterListagem()
        {
            tabelaQuestao ??= new TabelaQuestaoControl();

            AtualizarListagem();

            return tabelaQuestao;
        }

    }
}
