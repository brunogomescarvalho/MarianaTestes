using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {    
        public TabelaMateriaControl()
        {
            InitializeComponent();

            CriarColunas();

            dataGridMateria.ConfigurarGridSomenteLeitura();

            dataGridMateria.ConfigurarGridZebrado();        
        }

      
        public int BuscarIdMateriaSelecionada()
        {
            try
            {
                return Convert.ToInt32(dataGridMateria.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return -1;
            }
        }

        public void AtualizarLista(List<Materia> materias)
        {
            dataGridMateria.Rows.Clear();

            materias.ForEach(i =>
            {
                dataGridMateria.Rows.Add(i.Id, i.Nome, i.Serie, i.Disciplina.Nome );

            });
        }
        private void CriarColunas()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                { Name = "id", HeaderText = "Número"},

                new DataGridViewTextBoxColumn()
                { Name = "nome", HeaderText = "Matéria"},

                new DataGridViewTextBoxColumn()
                { Name = "serie", HeaderText = "Série"},

                new DataGridViewTextBoxColumn()
                { Name = "disciplina", HeaderText = "Disciplina"},

            };
            dataGridMateria.Columns.AddRange(columns);
        }
    }
}