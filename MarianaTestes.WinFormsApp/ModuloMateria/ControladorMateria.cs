using FluentResults;
using MarianaTestes.Aplicacao.ModuloMateria;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        IRepositorioMateria repositorioMateria;

        IRepositorioDisciplina repositorioDisciplina;

        ServicoMateria servicoMateria;

        TabelaMateriaControl? TabelaMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, ServicoMateria servicoMateria)
        {
            this.repositorioMateria = repositorioMateria;

            this.repositorioDisciplina = repositorioDisciplina;

            this.servicoMateria = servicoMateria;

            ConfigurarTela();
            
        }

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.BuscarTodos();

            TelaMateriaForm tela = new TelaMateriaForm(disciplinas);

            tela._onGravarRegistro += servicoMateria.Inserir;

            DialogResult dialog = tela.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                AtualizarListagem();
            }
        }

        public override void Editar()
        {
            int idMateria = TabelaMateria!.BuscarIdMateriaSelecionada();

            if (idMateria == -1) return;

            Materia materia = repositorioMateria.BuscarPorId(idMateria);

            DialogResult opcao = MessageBox.Show($"Confirma editar a matéria {materia.Nome} ?", "Editar matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.Cancel) return;

            List<Disciplina> disciplinas = repositorioDisciplina.BuscarTodos();

            TelaMateriaForm telaMateria = new TelaMateriaForm(disciplinas);

            telaMateria.Materia = materia;

            telaMateria.Text = "Editar Matéria";

            telaMateria._onGravarRegistro += servicoMateria.Editar;

            DialogResult dialog = telaMateria.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                AtualizarListagem();
            }
        }

        public override void Excluir()
        {
            int idMateria = TabelaMateria!.BuscarIdMateriaSelecionada();

            if (idMateria == -1) return;

            Materia materia = repositorioMateria.BuscarPorId(idMateria);

            DialogResult opcao = MessageBox.Show($"Confima excluir a matéria {materia.Nome} ?", "Excluir matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                Result result = servicoMateria.Excluir(materia);   

                if(result.IsFailed)
                {
                    MessageBox.Show($"{result.Errors[0].Message}", "Excluir Matéria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }

            }
        }

        public override void Filtrar()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.BuscarTodos();

            TelaFiltrarMateria telaMateria = new TelaFiltrarMateria(disciplinas);

            DialogResult dialog = telaMateria.ShowDialog();

            if(dialog == DialogResult.OK)
            {
                Disciplina disciplina = telaMateria.disciplina;

                if(disciplina != null)
                {
                    List<Materia> materias = repositorioMateria.FiltrarPorDisciplina(disciplina.Id);

                    TabelaMateria!.AtualizarLista(materias);

                    MostrarMsgRodape(materias);
                }
                else
                {
                    AtualizarListagem();
                }
            }
        }

        public override void AtualizarListagem()
        {
            var registros = repositorioMateria.BuscarTodos();

            TabelaMateria?.AtualizarLista(registros);

            MostrarMsgRodape(registros);
        }

        public override void ConfigurarTela()
        {
            Configuracao ??= new Configuracao("Inserir Matéria", "Editar Matéria", "Excluir Matéria")
            {
                BtnFiltrarEnabled = true,
                ToolTipFiltrar = "Filtrar Matérias"
            };
        }

        public override UserControl ObterListagem()
        {
            if (TabelaMateria == null)
            {
                TabelaMateria = new TabelaMateriaControl();
            }

            AtualizarListagem();

            return TabelaMateria;
        }

        private static void MostrarMsgRodape(List<Materia> registros)
        {
            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(registros.Count == 0 ? "Nenhuma Matéria cadastrada até o momento!" : registros.Count == 1 ? "Exibindo 1 Matéria" : $"Exibindo {registros.Count} matérias");
        }
    }
}
