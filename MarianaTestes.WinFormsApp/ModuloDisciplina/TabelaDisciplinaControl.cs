using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();

            CriarColunas();

            dataGridDisciplina.ConfigurarGridSomenteLeitura();

            dataGridDisciplina.ConfigurarGridZebrado();         
        }

        public int BuscarIdDisciplinaSelecionada()
        {
            try
            {
               return Convert.ToInt32(dataGridDisciplina.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return -1;
            }
               
        }

        public void AtualizarLista(List<Disciplina> disciplinas)
        {
           
            dataGridDisciplina.Rows.Clear();

            disciplinas.ForEach(i =>
            {
                dataGridDisciplina.Rows.Add(i.Id, i.Nome);
            });
        }

        private void CriarColunas()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                {Name = "id", HeaderText = "Número" },

                new DataGridViewTextBoxColumn()
                {Name = "nome", HeaderText = "Disciplina"}
            };

            dataGridDisciplina.Columns.AddRange(columns);
        }

    }
}
