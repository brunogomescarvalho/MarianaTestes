
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    public partial class TelaFiltrarQuestoesForm : Form
    {
        public Materia Materia = null!;

        public FiltroDeQuestao filtro;

        public TelaFiltrarQuestoesForm(List<Materia> materias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            IncluirEventoAlterarCamposDeBusca();

            materias.ForEach(i => comboMateria.Items.Add(i));

        }

        private void IncluirEventoAlterarCamposDeBusca()
        {
            foreach (RadioButton item in groupOpcaoBusca.Controls)
            {
                item.CheckedChanged += AlterarCamposAtivos_CheckedChanged!;
            }
        }

        private void AlterarCamposAtivos_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonTodas.Checked || radioButtonNaoUtilizadas.Checked)
            {
                groupMateria.Enabled = false;
                comboMateria.SelectedItem = null;
            }
            else
            {
                groupMateria.Enabled = true;
                comboMateria.SelectedItem = comboMateria.Items[0];
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (radioButtonMateria.Checked)
            {
                filtro = FiltroDeQuestao.Materia;

                Materia = (Materia)comboMateria.SelectedItem;
            }             
            else if (radioButtonTodas.Checked)
            {
                filtro = FiltroDeQuestao.Todas;
            }               
            else if (radioButtonNaoUtilizadas.Checked)
            {
                filtro = FiltroDeQuestao.NaoUtilizadas;
            }
                                   
        }
    }
}
