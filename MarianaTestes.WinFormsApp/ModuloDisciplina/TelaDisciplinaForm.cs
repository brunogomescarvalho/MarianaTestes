using FluentResults;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {

        private Disciplina disciplina;

       public onGravarRegistro<Disciplina> _onGravarRegistro;

        public Disciplina Disciplina
        {
            get => disciplina;

            set
            {
                textID.Text = value.Id.ToString();
                textDisciplina.Text = value.Nome;
            }
        }
        public TelaDisciplinaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void BtnCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            string id = textID.Text;

            string nome = textDisciplina.Text;

            disciplina = new Disciplina(nome);

            if (id != string.Empty)
            {
                disciplina.Id = Convert.ToInt32(id);
            }

           Result result = _onGravarRegistro(disciplina);

            if (result.IsFailed)
            {
                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(result.Errors[0].Message);

                DialogResult = DialogResult.None;
            }
        }
    }
}
