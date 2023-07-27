using MarianaTestes.WinFormsApp.Compartilhado;
using MarianaTestes.WinFormsApp.ModuloTeste;

namespace MarianaTestes.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador = null!;

        public static TelaPrincipalForm? TelaPrincipal { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            TelaPrincipal = this;

            this.txtMenu.Text = string.Empty;
        }

        public void AlterarLabelMenu(string texto)
        {
            this.txtMenu.Text = texto;
        }

        public void AlterarLabelRodape(string texto)
        {
            this.txtLabelRodape.Text = texto;
        }

        private void DisciplinaMenuItem_Click(object sender, EventArgs e)
        {
            AlterarLabelMenu("Cadastro Disciplina");

            controlador = IoC.ObterControlador(sender);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);


        }

        private void MateriaMenuItem_Click(object sender, EventArgs e)
        {
            AlterarLabelMenu("Cadastro Matéria");

            controlador = IoC.ObterControlador(sender);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);



        }

        private void QuestãoMenuItem_Click(object sender, EventArgs e)
        {
            AlterarLabelMenu("Cadastro Questão");

            controlador = IoC.ObterControlador(sender);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);
        }

        private void Testeitem_Click(object sender, EventArgs e)
        {
            AlterarLabelMenu("Cadastro Teste");

            controlador = IoC.ObterControlador(sender);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);
        }

        private void ConfigurarTabela(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            painelTelaPrincipal.Controls.Clear();
            painelTelaPrincipal.Controls.Add(listagem);

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.Configuracao.ToolTipInserir;
            btnEditar.ToolTipText = controlador.Configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.Configuracao.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.Configuracao.ToolTipFiltrar;
            btnDetalhes.ToolTipText = controlador.Configuracao.ToolTipDetalhes;
            btnDuplicar.ToolTipText = controlador.Configuracao.ToolTipDuplicar;
            BtnGerarPDF.ToolTipText = controlador.Configuracao.ToolTipGerarPdf;
        }

        private void ConfigurarBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.Configuracao.BtnAdicionarEnabled;
            btnEditar.Enabled = controlador.Configuracao.BtnEditarEnabled;
            btnExcluir.Enabled = controlador.Configuracao.BtnExcluirEnabled;
            btnFiltrar.Enabled = controlador.Configuracao.BtnFiltrarEnabled;
            btnDetalhes.Enabled = controlador.Configuracao.BtnDetalhesEnabled;
            btnDuplicar.Enabled = controlador.Configuracao.BtnDuplicarEnabled;
            BtnGerarPDF.Enabled = controlador.Configuracao.BtnGerarPdfEnable;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }


        private void BtnFiltrar_Click_1(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            controlador.ObterDetalhes();
        }

        private void BtnDuplicar_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorTeste controladorTeste)
            {
                controladorTeste.DuplicarTeste();
            }
        }

        private void BtnGerarPDF_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorTeste controladorTeste)
            {
                controladorTeste.GerarPdfTesteCadastrado();
            }
        }
    }
}