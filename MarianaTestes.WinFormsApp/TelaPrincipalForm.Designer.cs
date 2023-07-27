namespace MarianaTestes.WinFormsApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            questãoMenuItem = new ToolStripMenuItem();
            testeitem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            txtLabelRodape = new ToolStripStatusLabel();
            labelMenu = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDetalhes = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDuplicar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            txtMenu = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            painelTelaPrincipal = new Panel();
            BtnGerarPDF = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            labelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1028, 50);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, materiaMenuItem, questãoMenuItem, testeitem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.Image = Properties.Resources.menu_FILL0_wght200_GRAD0_opsz40;
            cadastrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(139, 44);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Image = Properties.Resources.import_contacts_FILL0_wght400_GRAD0_opsz40;
            disciplinaMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(186, 46);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += DisciplinaMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Image = Properties.Resources.note_add_FILL0_wght400_GRAD0_opsz40;
            materiaMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(186, 46);
            materiaMenuItem.Text = "Matéria";
            materiaMenuItem.Click += MateriaMenuItem_Click;
            // 
            // questãoMenuItem
            // 
            questãoMenuItem.Image = Properties.Resources.playlist_add_check_FILL0_wght400_GRAD0_opsz40;
            questãoMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            questãoMenuItem.Name = "questãoMenuItem";
            questãoMenuItem.Size = new Size(186, 46);
            questãoMenuItem.Text = "Questão";
            questãoMenuItem.Click += QuestãoMenuItem_Click;
            // 
            // testeitem
            // 
            testeitem.Image = Properties.Resources.psychology_alt_FILL0_wght400_GRAD0_opsz40;
            testeitem.ImageScaling = ToolStripItemImageScaling.None;
            testeitem.Name = "testeitem";
            testeitem.Size = new Size(186, 46);
            testeitem.Text = "Teste";
            testeitem.Click += Testeitem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtLabelRodape });
            statusStrip1.Location = new Point(0, 668);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1028, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtLabelRodape
            // 
            txtLabelRodape.Name = "txtLabelRodape";
            txtLabelRodape.Size = new Size(0, 16);
            // 
            // labelMenu
            // 
            labelMenu.BackColor = Color.FloralWhite;
            labelMenu.ImageScalingSize = new Size(20, 20);
            labelMenu.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator1, btnDetalhes, toolStripSeparator3, btnDuplicar, BtnGerarPDF, toolStripSeparator4, txtMenu, toolStripLabel1, toolStripLabel2 });
            labelMenu.Location = new Point(0, 50);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(1028, 57);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz40;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(5);
            btnInserir.Size = new Size(54, 54);
            btnInserir.Click += BtnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz40;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(54, 54);
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.close_FILL0_wght400_GRAD0_opsz40;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(54, 54);
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 57);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(52, 54);
            btnFiltrar.Click += BtnFiltrar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 57);
            // 
            // btnDetalhes
            // 
            btnDetalhes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDetalhes.Enabled = false;
            btnDetalhes.Image = Properties.Resources.info_FILL0_wght400_GRAD0_opsz40;
            btnDetalhes.ImageScaling = ToolStripItemImageScaling.None;
            btnDetalhes.ImageTransparentColor = Color.Magenta;
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(44, 54);
            btnDetalhes.Click += BtnDetalhes_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 57);
            // 
            // btnDuplicar
            // 
            btnDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicar.Enabled = false;
            btnDuplicar.Image = Properties.Resources.note_add_FILL0_wght400_GRAD0_opsz40;
            btnDuplicar.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicar.ImageTransparentColor = Color.Magenta;
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Size = new Size(44, 54);
            btnDuplicar.Click += BtnDuplicar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 57);
            // 
            // txtMenu
            // 
            txtMenu.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenu.ForeColor = Color.Black;
            txtMenu.ImageScaling = ToolStripItemImageScaling.None;
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(134, 54);
            txtMenu.Text = "Tipo Cadastro";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.ForeColor = SystemColors.Info;
            toolStripLabel1.Image = Properties.Resources.school_FILL0_wght400_GRAD0_opsz48;
            toolStripLabel1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(87, 54);
            toolStripLabel1.Text = "-----";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel2.ForeColor = Color.Black;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(141, 54);
            toolStripLabel2.Text = "Mariana Testes";
            // 
            // painelTelaPrincipal
            // 
            painelTelaPrincipal.BackColor = SystemColors.ActiveBorder;
            painelTelaPrincipal.BorderStyle = BorderStyle.FixedSingle;
            painelTelaPrincipal.Dock = DockStyle.Fill;
            painelTelaPrincipal.Location = new Point(0, 107);
            painelTelaPrincipal.Margin = new Padding(3, 5, 3, 5);
            painelTelaPrincipal.Name = "painelTelaPrincipal";
            painelTelaPrincipal.Size = new Size(1028, 561);
            painelTelaPrincipal.TabIndex = 3;
            // 
            // BtnGerarPDF
            // 
            BtnGerarPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnGerarPDF.Enabled = false;
            BtnGerarPDF.Image = Properties.Resources.picture_as_pdf_FILL0_wght300_GRAD0_opsz40;
            BtnGerarPDF.ImageScaling = ToolStripItemImageScaling.None;
            BtnGerarPDF.ImageTransparentColor = Color.Magenta;
            BtnGerarPDF.Name = "BtnGerarPDF";
            BtnGerarPDF.Size = new Size(44, 54);
            BtnGerarPDF.Click += BtnGerarPDF_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 690);
            Controls.Add(painelTelaPrincipal);
            Controls.Add(labelMenu);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(466, 364);
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            labelMenu.ResumeLayout(false);
            labelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private ToolStripMenuItem questãoMenuItem;
        private ToolStripMenuItem testeitem;
        private StatusStrip statusStrip1;
        private ToolStrip labelMenu;
        private ToolStripButton btnExcluir;
        private Panel painelTelaPrincipal;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnFiltrar;
        private ToolStripStatusLabel txtLabelRodape;
        private ToolStripButton btnDetalhes;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel txtMenu;
        private ToolStripButton btnDuplicar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton BtnGerarPDF;
    }
}