using FluentResults;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        public event onGravarRegistro<Questao> _onGravarRegistro;

        Questao questao;
        public Questao Questao
        {
            get => questao;

            set
            {
                PreencherCamposParaEditar(value);
            }
        }

        public TelaQuestaoForm(List<Materia> materias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            materias.ForEach(i => txtComboMateria.Items.Add(i));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            string idQuestao = txtIdQuestao.Text;

            string pergunta = txtQuestao.Text;

            Materia materia = (Materia)txtComboMateria.SelectedItem;

            questao = new Questao(pergunta, materia);

            for (int i = 0; i < listAlternativas.Items.Count; i++)
            {
                Alternativa alternativa = (Alternativa)listAlternativas.Items[i];

                alternativa.EhCorreta = listAlternativas.GetItemChecked(i);

                questao.AdicionarAlternativa(alternativa);
            }

            if (idQuestao != string.Empty)
            {
                questao.Id = Convert.ToInt32(idQuestao);
            }

            Result result = _onGravarRegistro(questao);

            if (result.IsFailed)
            {
                TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape(result.Errors[0].Message);

                DialogResult = DialogResult.None;
            }
        }

        private void PreencherCamposParaEditar(Questao questao)
        {
            txtIdQuestao.Text = Convert.ToString(questao.Id);

            foreach (Materia item in txtComboMateria.Items)
            {
                if (item.Id == questao.Materia.Id)
                {
                    txtComboMateria.SelectedItem = item;
                    break;
                }
            }

            txtQuestao.Text = questao.Pergunta;

            int i = 0;

            foreach (Alternativa item in questao.Alternativas)
            {
                listAlternativas.Items.Add(item);

                if (item.EhCorreta)
                {
                    listAlternativas.SetItemChecked(i, true);
                }

                i++;
            }

            groupAlternativas.Text = $"Alternativa: N° {listAlternativas.Items.Count + 1}";
        }

        private void BtnAdicionarAlternativa_Click(object sender, EventArgs e)
        {
            if (txtAlternativa.Text == string.Empty)
                return;

            listAlternativas.Items.Add(new Alternativa(txtAlternativa.Text, false));

            groupAlternativas.Text = $"Alternativa: N° {listAlternativas.Items.Count + 1}";

            txtAlternativa.Text = string.Empty;
        }

        private void BtnExcluirAlternativa_Click(object sender, EventArgs e)
        {
            if (listAlternativas.SelectedIndex == -1)
                return;

            listAlternativas.Items.RemoveAt(listAlternativas.SelectedIndex);

            groupAlternativas.Text = $"Alternativa: N° {listAlternativas.Items.Count + 1}";
        }


      
    }
}
