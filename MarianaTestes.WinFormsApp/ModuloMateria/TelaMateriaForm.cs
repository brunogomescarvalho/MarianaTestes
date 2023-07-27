
using FluentResults;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;

        public onGravarRegistro<Materia> _onGravarRegistro;

        public Materia Materia
        {
            get => materia;
            set
            {
                PreencherCamposEditar(value);
            }
        }
        public TelaMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarFormulario(disciplinas);

        }

        private void ConfigurarFormulario(List<Disciplina> disciplinas)
        {

            List<SerieMateriaEnum> series = Enum.GetValues<SerieMateriaEnum>().ToList();

            series.ForEach(i => comboBoxSerie.Items.Add(i));

            disciplinas.ForEach(disciplina => { comboBoxDisciplina.Items.Add(disciplina); });
        }

        private void PreencherCamposEditar(Materia materia)
        {
            txtIDMateria.Text = Convert.ToString(materia.Id);

            txtNomeMateria.Text = materia.Nome;


            foreach (SerieMateriaEnum serie in comboBoxSerie.Items)
            {
                if (serie == materia.Serie)
                {
                    comboBoxSerie.SelectedItem = serie;
                    break;
                }
            }

            foreach (Disciplina item in comboBoxDisciplina.Items)
            {
                if (item.Id == materia.Disciplina.Id)
                {
                    comboBoxDisciplina.SelectedItem = item;
                    break;
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {          
            string nome = txtNomeMateria.Text;

            Disciplina disciplina = (Disciplina)comboBoxDisciplina.SelectedItem;

            SerieMateriaEnum? serie = (SerieMateriaEnum?)comboBoxSerie.SelectedItem;

            materia = new Materia(nome, serie, disciplina);

            if (txtIDMateria.Text != string.Empty)
            {
                materia.Id = Convert.ToInt32(txtIDMateria.Text);
            }

            Result result = _onGravarRegistro(materia);

            if (result.IsFailed)
            {
                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(result.Errors[0].Message);

                DialogResult = DialogResult.None;
            }

        }

    }
}
