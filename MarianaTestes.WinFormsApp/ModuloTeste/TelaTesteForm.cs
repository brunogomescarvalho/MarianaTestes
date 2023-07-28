using FluentResults;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    public delegate Disciplina onObterMateriasDisciplina_EventHandler(Disciplina disciplina);

    public delegate Materia onObterQuestoesMateria_EventHandler(Materia materia);

    public delegate List<Questao> onObterDisciplinaESerie(Disciplina disciplina, SerieMateriaEnum serie);

    public delegate string onEnviarMensagemQuestoesInfuficientes(string msg);

    public partial class TelaTesteForm : Form
    {
        public onObterMateriasDisciplina_EventHandler onObterMateriasDisciplina_;

        public onObterQuestoesMateria_EventHandler onObterQuestoesMateria_;

        public onObterDisciplinaESerie onObterDisciplinaESerie_;

        public event onGravarRegistro<Teste> onGravarRegistro_;

        private Teste teste;

        public Teste Teste
        {
            get => teste;
            set
            {
                CarregarCampos(value);
            }
        }

        public TelaTesteForm(List<Disciplina> disciplinas, Teste teste)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.teste = teste;

            this.teste.InformarQtdInsuficiente += EnviarMensagemQuestoesInsuficientes;

            CarregarDisciplinas(disciplinas!);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            disciplinas.ForEach(disciplina => { txtComboBoxDisciplina.Items.Add(disciplina); });
        }


        private void TxtComboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disciplina disciplina = (Disciplina)txtComboBoxDisciplina.SelectedItem;

            if (!txtRecuperacao.Checked)
            {
                txtMaterias.DataSource = onObterMateriasDisciplina_(disciplina).Materias;
            }

            listQuestoes.Items.Clear();
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            if (txtMaterias.SelectedItem == null && !txtRecuperacao.Checked)
                return;

            int qtdQuestoes = (int)txtQtdQuestoes.Value;

            List<Questao> questoes = null!;

            if (!txtRecuperacao.Checked)
            {
                questoes = onObterQuestoesMateria_((Materia)txtMaterias.SelectedItem!).Questoes;
            }
            else if (txtComboSerie.SelectedItem != null && txtComboBoxDisciplina.SelectedItem != null)
            {
                var disciplina = (Disciplina)txtComboBoxDisciplina.SelectedItem;

                var serie = (SerieMateriaEnum)txtComboSerie.SelectedItem;

                questoes = onObterDisciplinaESerie_(disciplina, serie);
            }

            listQuestoes.Items.Clear();

            teste.ObterQuestoesSorteadas(questoes, qtdQuestoes);

            if (teste.Questoes.Count > 0)
                teste.Questoes.ForEach(x => listQuestoes.Items.Add(x));
        }


        private void TxtMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            var disciplina = (Disciplina)txtComboBoxDisciplina.SelectedItem;

            var materia = (Materia)txtMaterias.SelectedItem;

            int qdtQuestoes = Convert.ToInt32(txtQtdQuestoes.Value);

            bool recuperacao = Convert.ToBoolean(txtRecuperacao.Checked);

            var serie = (SerieMateriaEnum?)txtComboSerie.SelectedItem;

            teste.Titulo = titulo;
            teste.Disciplina = disciplina;
            teste.Materia = materia;
            teste.Serie = materia == null ? serie : materia.Serie;
            teste.DataTeste = DateTime.Now;
            teste.Recuperacao = recuperacao;


            Result result = onGravarRegistro_(teste);

            if (result.IsFailed)
            {
                DialogResult = DialogResult.None;

                EnviarMensagem(result.Errors[0].Message);
            }
        }

        private void EnviarMensagem(string msg)
        {
            TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape(msg);
        }

        private void TxtRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            if (check.Checked)
            {
                txtMaterias.Enabled = false;

                txtMaterias.SelectedItem = null;

                Enum.GetValues<SerieMateriaEnum>().ToList().ForEach(i => txtComboSerie.Items.Add(i));

                txtComboSerie.Enabled = true;

                txtComboSerie.SelectedItem = txtComboSerie.Items[0];
            }
            else
            {
                txtMaterias.Enabled = true;

                txtComboSerie.Items.Clear();

                txtComboSerie.Text = "";

                txtComboSerie.Enabled = false;

                TxtComboBoxDisciplina_SelectedIndexChanged(sender, e);

            }
        }

        private void EnviarMensagemQuestoesInsuficientes(string msg)
        {
            MessageBox.Show(msg, "Sortear Questões", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CarregarCampos(Teste value)
        {
            txtTitulo.Text = value.Titulo;
            txtComboBoxDisciplina.SelectedItem = txtComboBoxDisciplina.Items.Cast<Disciplina>().ToList().Find(i => i.Equals(value.Disciplina));
            txtMaterias.SelectedItem = txtMaterias.Items.Cast<Materia>().ToList().Find(i => i.Equals(value.Materia));
            txtQtdQuestoes.Value = value.QtdQuestoes == 0 ? 2 : value.QtdQuestoes;
            txtRecuperacao.Checked = value.Recuperacao;
        }
    }
}
