using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();

            GerarTabela();

            dataGridTeste.ConfigurarGridSomenteLeitura();

            dataGridTeste.ConfigurarGridZebrado();          
        }


        public void AtualizarLista(List<Teste> testes)
        {
            dataGridTeste.Rows.Clear();

            testes.ForEach(i =>
            {
                dataGridTeste.Rows.Add(i.Id, i.Titulo, $"{i.DataTeste:d}", i.QtdQuestoes, i.Serie
                , i?.Materia?.Nome, i.Disciplina.Nome, i.Recuperacao?"Sim":"Não", i.TempoDesdeRealizacao);
            });

        }

        public int ObterIdTesteSelecionado()
        {
            try
            {
                return Convert.ToInt32(dataGridTeste.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return -1;
            }

        }

        private void GerarTabela()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "numero",
                    HeaderText= "Número"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText= "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText= "Data Teste"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "qtdQuestoes",
                    HeaderText= "Qtd Questões"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "serie",
                    HeaderText= "Série"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText= "Matéria"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText= "Disciplina"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "recuperacao",
                    HeaderText= "Recuperação"
                },
                    new DataGridViewTextBoxColumn()
                {
                    Name = "tempoRealizado",
                    HeaderText= "Tempo desde à realização"
                },
            };

            dataGridTeste.Columns.AddRange(columns);
        }
    }
}
