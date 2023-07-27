using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    public delegate void onVisualizarPdf(Teste teste);

    public partial class TelaTestePdfForm : Form
    {
        public string? Diretorio;

        public onVisualizarPdf onVisualizarPdf;

        private Teste teste;

        public TelaTestePdfForm(Teste teste)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.teste = teste;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = folderDialog.SelectedPath;       
            }
            else
            {
                CheckOpcao.Checked = true;
                txtCaminho.Text = "";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Diretorio = CheckOpcao.Checked? null : txtCaminho.Text;
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            onVisualizarPdf(teste);
        }

        private void CheckOpcao_CheckedChanged(object sender, EventArgs e)
        {
            groupCaminho.Enabled = !CheckOpcao.Checked;
            txtCaminho.Text = "";
        }
    }
}
