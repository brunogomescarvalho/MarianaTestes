namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            txtComboMateria = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtIdQuestao = new TextBox();
            txtQuestao = new TextBox();
            groupAlternativas = new GroupBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            BtnAdicionarAlternativa = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnExcluirAlternativa = new ToolStripButton();
            txtAlternativa = new TextBox();
            groupBox1 = new GroupBox();
            listAlternativas = new CheckedListBox();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            groupAlternativas.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // txtComboMateria
            // 
            txtComboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboMateria.FormattingEnabled = true;
            txtComboMateria.Location = new Point(92, 72);
            txtComboMateria.Margin = new Padding(3, 4, 3, 4);
            txtComboMateria.Name = "txtComboMateria";
            txtComboMateria.Size = new Size(398, 28);
            txtComboMateria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 129);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Questão:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 26);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Número:";
            // 
            // txtIdQuestao
            // 
            txtIdQuestao.Location = new Point(93, 19);
            txtIdQuestao.Margin = new Padding(3, 4, 3, 4);
            txtIdQuestao.Name = "txtIdQuestao";
            txtIdQuestao.ReadOnly = true;
            txtIdQuestao.Size = new Size(63, 27);
            txtIdQuestao.TabIndex = 4;
            txtIdQuestao.TabStop = false;
            // 
            // txtQuestao
            // 
            txtQuestao.Location = new Point(93, 122);
            txtQuestao.Margin = new Padding(3, 4, 3, 4);
            txtQuestao.Multiline = true;
            txtQuestao.Name = "txtQuestao";
            txtQuestao.Size = new Size(400, 43);
            txtQuestao.TabIndex = 2;
            // 
            // groupAlternativas
            // 
            groupAlternativas.BackColor = SystemColors.Control;
            groupAlternativas.Controls.Add(panel1);
            groupAlternativas.Controls.Add(groupBox1);
            groupAlternativas.Location = new Point(32, 173);
            groupAlternativas.Margin = new Padding(3, 4, 3, 4);
            groupAlternativas.Name = "groupAlternativas";
            groupAlternativas.Padding = new Padding(3, 4, 3, 4);
            groupAlternativas.Size = new Size(464, 291);
            groupAlternativas.TabIndex = 6;
            groupAlternativas.TabStop = false;
            groupAlternativas.Text = "Alternativa: N° 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 56);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtAlternativa, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(458, 56);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnAdicionarAlternativa, toolStripSeparator1, BtnExcluirAlternativa });
            toolStrip1.Location = new Point(343, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(115, 56);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnAdicionarAlternativa
            // 
            BtnAdicionarAlternativa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnAdicionarAlternativa.Image = Properties.Resources.add_circle_FILL0_wght200_GRAD0_opsz40__1_;
            BtnAdicionarAlternativa.ImageScaling = ToolStripItemImageScaling.None;
            BtnAdicionarAlternativa.ImageTransparentColor = Color.Magenta;
            BtnAdicionarAlternativa.MergeIndex = 4;
            BtnAdicionarAlternativa.Name = "BtnAdicionarAlternativa";
            BtnAdicionarAlternativa.Size = new Size(44, 53);
            BtnAdicionarAlternativa.Text = "toolStripButton1";
            BtnAdicionarAlternativa.ToolTipText = "Adicionar Alternativa";
            BtnAdicionarAlternativa.Click += BtnAdicionarAlternativa_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 56);
            // 
            // BtnExcluirAlternativa
            // 
            BtnExcluirAlternativa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnExcluirAlternativa.Image = Properties.Resources.delete_FILL0_wght200_GRAD0_opsz40__1_;
            BtnExcluirAlternativa.ImageScaling = ToolStripItemImageScaling.None;
            BtnExcluirAlternativa.ImageTransparentColor = Color.Magenta;
            BtnExcluirAlternativa.MergeIndex = 5;
            BtnExcluirAlternativa.Name = "BtnExcluirAlternativa";
            BtnExcluirAlternativa.Size = new Size(44, 53);
            BtnExcluirAlternativa.Text = "toolStripButton2";
            BtnExcluirAlternativa.ToolTipText = "Excluir Alternativa";
            BtnExcluirAlternativa.Click += BtnExcluirAlternativa_Click;
            // 
            // txtAlternativa
            // 
            txtAlternativa.Dock = DockStyle.Fill;
            txtAlternativa.Location = new Point(3, 3);
            txtAlternativa.Multiline = true;
            txtAlternativa.Name = "txtAlternativa";
            txtAlternativa.Size = new Size(337, 50);
            txtAlternativa.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listAlternativas);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione a Alternativa Correta";
            // 
            // listAlternativas
            // 
            listAlternativas.BorderStyle = BorderStyle.None;
            listAlternativas.Dock = DockStyle.Fill;
            listAlternativas.FormattingEnabled = true;
            listAlternativas.Location = new Point(3, 23);
            listAlternativas.Name = "listAlternativas";
            listAlternativas.Size = new Size(452, 181);
            listAlternativas.TabIndex = 6;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalvar.DialogResult = DialogResult.OK;
            BtnSalvar.Location = new Point(298, 485);
            BtnSalvar.Margin = new Padding(3, 4, 3, 4);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(86, 42);
            BtnSalvar.TabIndex = 7;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(410, 485);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 42);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 559);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(groupAlternativas);
            Controls.Add(txtQuestao);
            Controls.Add(txtIdQuestao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtComboMateria);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaQuestaoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Questões";
            groupAlternativas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox txtComboMateria;
        private Label label2;
        private Label label3;
        private TextBox txtIdQuestao;
        private TextBox txtQuestao;
        private GroupBox groupAlternativas;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private GroupBox groupBox1;
        private CheckedListBox listAlternativas;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnAdicionarAlternativa;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnExcluirAlternativa;
        private TextBox txtAlternativa;
    }
}