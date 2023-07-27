using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    public partial class TelaDetalhesTeste : Form
    {
        public TelaDetalhesTeste(Teste teste)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            textBox.Text = teste.ObterTesteString(gabarito: false);
        }
    }
}
