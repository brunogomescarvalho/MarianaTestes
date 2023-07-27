using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    public partial class TelaDetalhesQuestaoForm : Form
    {
        public TelaDetalhesQuestaoForm(Questao questao)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            txtMateria.Text = questao.Materia.Nome;

            txtSerie.Text = Convert.ToString(questao.Materia.Serie);

            txtId.Text = Convert.ToString(questao.Id);

            txtPergunta.Text = questao.Pergunta;

            foreach (Alternativa item in questao.Alternativas)
            {
                int i = questao.Alternativas.IndexOf(item) + 1;

                if (item.EhCorreta)
                {
                    txtCorreta.Text = $"[{i}] {item.Texto}";
                }

                listAlternativas.Items.Add($"[{i}] {item.Texto}");
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
