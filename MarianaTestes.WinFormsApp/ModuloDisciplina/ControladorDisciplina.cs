using FluentResults;
using MarianaTestes.Aplicacao.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        IRepositorioDisciplina repositorioDisciplina;

        ServicoDisciplina servicoDisciplina;

        TabelaDisciplinaControl? tabelaDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina, ServicoDisciplina servicoDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;

            this.servicoDisciplina = servicoDisciplina;

            ConfigurarTela();
        }

        public override void ConfigurarTela()
        {
            Configuracao ??= new Configuracao("Inserir Disciplina", "Editar Disciplina", "Excluir Disciplina");
        }
        public override UserControl ObterListagem()
        {
            tabelaDisciplinas ??= new TabelaDisciplinaControl();

            AtualizarListagem();

            return tabelaDisciplinas;
        }
        public override void Inserir()
        {
            TelaDisciplinaForm tela = new TelaDisciplinaForm();

            tela._onGravarRegistro += servicoDisciplina.Inserir;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarListagem();
            }
        }

        public override void Editar()
        {
            int IdDisciplina = tabelaDisciplinas!.BuscarIdDisciplinaSelecionada();

            if (IdDisciplina == -1) return;

            Disciplina disciplina = repositorioDisciplina.BuscarPorId(IdDisciplina);

            DialogResult opcao = MessageBox.Show($"Confirma editar a Disciplina {disciplina.Nome} ?", "Editar Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                TelaDisciplinaForm tela = new TelaDisciplinaForm()
                {
                    Text = "Editar Disciplina"
                };

                tela.Disciplina = disciplina;

                tela._onGravarRegistro += servicoDisciplina.Editar;
         
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarListagem();
                }
            }
        }

        public override void Excluir()
        {
            int IdDisciplina = tabelaDisciplinas!.BuscarIdDisciplinaSelecionada();

            if (IdDisciplina == -1) return;

            Disciplina disciplina = repositorioDisciplina.BuscarPorId(IdDisciplina);

            DialogResult opcao = MessageBox.Show($"Confima excluir a Disciplina {disciplina.Nome} ?", "Excluir Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                Result result = servicoDisciplina.Excluir(disciplina);

                if (result.IsFailed)
                    MessageBox.Show($"{result.Errors[0].Message}", "Excluir Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    AtualizarListagem();
            }
        }

        public override void AtualizarListagem()
        {
            var registros = repositorioDisciplina.BuscarTodos();

            tabelaDisciplinas?.AtualizarLista(registros);

            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(registros.Count == 0 ? "Nenhuma Disciplina cadastrada até o momento!" : registros.Count == 1 ? "Exibindo 1 Disciplina" : $"Exibindo {registros.Count} disciplinas.");
        }
    }
}
