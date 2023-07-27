namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    partial class TelaTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtComboBoxDisciplina = new ComboBox();
            label2 = new Label();
            txtMaterias = new ComboBox();
            label3 = new Label();
            txtQtdQuestoes = new NumericUpDown();
            BtnGerar = new Button();
            BtnCancelar = new Button();
            label4 = new Label();
            txtTitulo = new TextBox();
            groupQuestoes = new GroupBox();
            listQuestoes = new ListBox();
            panel1 = new Panel();
            BtnSortear = new Button();
            txtRecuperacao = new CheckBox();
            txtComboSerie = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQtdQuestoes).BeginInit();
            groupQuestoes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 83);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Disciplina:";
            // 
            // txtComboBoxDisciplina
            // 
            txtComboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboBoxDisciplina.FormattingEnabled = true;
            txtComboBoxDisciplina.Location = new Point(89, 75);
            txtComboBoxDisciplina.Margin = new Padding(3, 4, 3, 4);
            txtComboBoxDisciplina.Name = "txtComboBoxDisciplina";
            txtComboBoxDisciplina.Size = new Size(308, 28);
            txtComboBoxDisciplina.TabIndex = 1;
            txtComboBoxDisciplina.SelectedIndexChanged += TxtComboBoxDisciplina_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Matéria:";
            // 
            // txtMaterias
            // 
            txtMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaterias.FormattingEnabled = true;
            txtMaterias.Location = new Point(89, 132);
            txtMaterias.Margin = new Padding(3, 4, 3, 4);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(308, 28);
            txtMaterias.TabIndex = 2;
            txtMaterias.SelectedIndexChanged += TxtMaterias_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 30);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Questões";
            // 
            // txtQtdQuestoes
            // 
            txtQtdQuestoes.Location = new Point(479, 23);
            txtQtdQuestoes.Margin = new Padding(3, 4, 3, 4);
            txtQtdQuestoes.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            txtQtdQuestoes.Name = "txtQtdQuestoes";
            txtQtdQuestoes.Size = new Size(76, 27);
            txtQtdQuestoes.TabIndex = 3;
            txtQtdQuestoes.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // BtnGerar
            // 
            BtnGerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGerar.DialogResult = DialogResult.OK;
            BtnGerar.Location = new Point(362, 613);
            BtnGerar.Margin = new Padding(3, 4, 3, 4);
            BtnGerar.Name = "BtnGerar";
            BtnGerar.Size = new Size(86, 43);
            BtnGerar.TabIndex = 8;
            BtnGerar.Text = "Gerar";
            BtnGerar.UseVisualStyleBackColor = true;
            BtnGerar.Click += BtnGerar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(466, 613);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 43);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 30);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 23);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(308, 27);
            txtTitulo.TabIndex = 0;
            // 
            // groupQuestoes
            // 
            groupQuestoes.Controls.Add(listQuestoes);
            groupQuestoes.Controls.Add(panel1);
            groupQuestoes.Location = new Point(37, 189);
            groupQuestoes.Margin = new Padding(3, 4, 3, 4);
            groupQuestoes.Name = "groupQuestoes";
            groupQuestoes.Padding = new Padding(3, 4, 3, 4);
            groupQuestoes.Size = new Size(518, 387);
            groupQuestoes.TabIndex = 8;
            groupQuestoes.TabStop = false;
            groupQuestoes.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Fill;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(3, 104);
            listQuestoes.Margin = new Padding(3, 4, 3, 4);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(512, 279);
            listQuestoes.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSortear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 80);
            panel1.TabIndex = 6;
            // 
            // BtnSortear
            // 
            BtnSortear.Location = new Point(199, 25);
            BtnSortear.Margin = new Padding(3, 4, 3, 4);
            BtnSortear.Name = "BtnSortear";
            BtnSortear.Size = new Size(127, 31);
            BtnSortear.TabIndex = 6;
            BtnSortear.Text = "Sortear Questões";
            BtnSortear.UseVisualStyleBackColor = true;
            BtnSortear.Click += BtnSortear_Click;
            // 
            // txtRecuperacao
            // 
            txtRecuperacao.AutoSize = true;
            txtRecuperacao.Location = new Point(417, 75);
            txtRecuperacao.Name = "txtRecuperacao";
            txtRecuperacao.Size = new Size(117, 24);
            txtRecuperacao.TabIndex = 4;
            txtRecuperacao.Text = "Recuperação";
            txtRecuperacao.UseVisualStyleBackColor = true;
            txtRecuperacao.CheckedChanged += TxtRecuperacao_CheckedChanged;
            // 
            // txtComboSerie
            // 
            txtComboSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboSerie.Enabled = false;
            txtComboSerie.FormattingEnabled = true;
            txtComboSerie.Location = new Point(417, 132);
            txtComboSerie.Name = "txtComboSerie";
            txtComboSerie.Size = new Size(138, 28);
            txtComboSerie.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 109);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 14;
            label5.Text = "Série";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 681);
            Controls.Add(label5);
            Controls.Add(txtComboSerie);
            Controls.Add(txtRecuperacao);
            Controls.Add(groupQuestoes);
            Controls.Add(txtTitulo);
            Controls.Add(label4);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGerar);
            Controls.Add(txtQtdQuestoes);
            Controls.Add(label3);
            Controls.Add(txtMaterias);
            Controls.Add(label2);
            Controls.Add(txtComboBoxDisciplina);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Teste";
            ((System.ComponentModel.ISupportInitialize)txtQtdQuestoes).EndInit();
            groupQuestoes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox txtComboBoxDisciplina;
        private Label label2;
        private ComboBox txtMaterias;
        private Label label3;
        private NumericUpDown txtQtdQuestoes;
        private Button BtnGerar;
        private Button BtnCancelar;
        private Label label4;
        private TextBox txtTitulo;
        private GroupBox groupQuestoes;
        private Button BtnSortear;
        private Panel panel1;
        private ListBox listQuestoes;
        private CheckBox txtRecuperacao;
        private ComboBox txtComboSerie;
        private Label label5;
    }
}