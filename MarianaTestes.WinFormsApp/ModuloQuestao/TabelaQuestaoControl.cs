using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {

            InitializeComponent();

            CriarColunas();

            dataGridQuestao.ConfigurarGridSomenteLeitura();

            dataGridQuestao.ConfigurarGridZebrado();
        }


        public int BuscarIdQuestaoSelecionada()
        {
            try
            {
                return Convert.ToInt32(dataGridQuestao.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return -1;
            }
        }

        public void AtualizarLista(List<Questao> questoes)
        {

            dataGridQuestao.Rows.Clear();

            questoes.ForEach(i =>
            {
                dataGridQuestao.Rows.Add(
                    i.Id,
                    i.Pergunta,
                    i.Materia.Nome,
                    i.Materia.Serie.ToString());
                   
            });
        }


        public bool TabelaVazia()
        {
            return dataGridQuestao.Rows.Count == 0;
        }

        private void CriarColunas()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                {Name = "id", HeaderText = "Número" },

                new DataGridViewTextBoxColumn()
                {Name = "pergunta", HeaderText = "Pergunta"},

                new DataGridViewTextBoxColumn()
                {Name = "materia", HeaderText = "Materia"},

                new DataGridViewTextBoxColumn()
                {Name = "seria", HeaderText = "Série"},

            };

            dataGridQuestao.Columns.AddRange(columns);
        }
    }
}
