namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    partial class TelaDetalhesQuestaoForm
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
            groupQuestao = new GroupBox();
            txtSerie = new Label();
            txtMateria = new Label();
            txtId = new Label();
            labelSerie = new Label();
            label2 = new Label();
            labelId = new Label();
            groupAlternativas = new GroupBox();
            txtCorreta = new TextBox();
            panel1 = new Panel();
            listAlternativas = new ListBox();
            label8 = new Label();
            BtnFechar = new Button();
            groupBoxPergunta = new GroupBox();
            txtPergunta = new TextBox();
            groupQuestao.SuspendLayout();
            groupAlternativas.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxPergunta.SuspendLayout();
            SuspendLayout();
            // 
            // groupQuestao
            // 
            groupQuestao.Controls.Add(txtSerie);
            groupQuestao.Controls.Add(txtMateria);
            groupQuestao.Controls.Add(txtId);
            groupQuestao.Controls.Add(labelSerie);
            groupQuestao.Controls.Add(label2);
            groupQuestao.Controls.Add(labelId);
            groupQuestao.Location = new Point(24, 24);
            groupQuestao.Name = "groupQuestao";
            groupQuestao.Size = new Size(434, 139);
            groupQuestao.TabIndex = 0;
            groupQuestao.TabStop = false;
            groupQuestao.Text = "Questão";
            // 
            // txtSerie
            // 
            txtSerie.AutoSize = true;
            txtSerie.Location = new Point(74, 94);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(29, 20);
            txtSerie.TabIndex = 8;
            txtSerie.Text = "=>";
            // 
            // txtMateria
            // 
            txtMateria.AutoSize = true;
            txtMateria.Location = new Point(74, 60);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(29, 20);
            txtMateria.TabIndex = 7;
            txtMateria.Text = "=>";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(74, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(29, 20);
            txtId.TabIndex = 6;
            txtId.Text = "=>";
            // 
            // labelSerie
            // 
            labelSerie.AutoSize = true;
            labelSerie.Location = new Point(23, 94);
            labelSerie.Name = "labelSerie";
            labelSerie.Size = new Size(45, 20);
            labelSerie.TabIndex = 4;
            labelSerie.Text = "Série:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Matéria:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(43, 28);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // groupAlternativas
            // 
            groupAlternativas.Controls.Add(txtCorreta);
            groupAlternativas.Controls.Add(panel1);
            groupAlternativas.Controls.Add(label8);
            groupAlternativas.Location = new Point(24, 287);
            groupAlternativas.Margin = new Padding(3, 4, 3, 4);
            groupAlternativas.Name = "groupAlternativas";
            groupAlternativas.Padding = new Padding(3, 4, 3, 4);
            groupAlternativas.Size = new Size(434, 298);
            groupAlternativas.TabIndex = 7;
            groupAlternativas.TabStop = false;
            groupAlternativas.Text = "Alternativas";
            // 
            // txtCorreta
            // 
            txtCorreta.Dock = DockStyle.Bottom;
            txtCorreta.Location = new Point(3, 243);
            txtCorreta.Multiline = true;
            txtCorreta.Name = "txtCorreta";
            txtCorreta.ReadOnly = true;
            txtCorreta.Size = new Size(428, 51);
            txtCorreta.TabIndex = 21;
            txtCorreta.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(listAlternativas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 190);
            panel1.TabIndex = 20;
            // 
            // listAlternativas
            // 
            listAlternativas.Dock = DockStyle.Fill;
            listAlternativas.FormattingEnabled = true;
            listAlternativas.ItemHeight = 20;
            listAlternativas.Location = new Point(0, 0);
            listAlternativas.Name = "listAlternativas";
            listAlternativas.SelectionMode = SelectionMode.None;
            listAlternativas.Size = new Size(428, 190);
            listAlternativas.TabIndex = 0;
            listAlternativas.TabStop = false;
            listAlternativas.UseTabStops = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 217);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 17;
            label8.Text = "Alternativa correta";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(364, 603);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(94, 49);
            BtnFechar.TabIndex = 8;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += Fechar_Click;
            // 
            // groupBoxPergunta
            // 
            groupBoxPergunta.Controls.Add(txtPergunta);
            groupBoxPergunta.Location = new Point(27, 169);
            groupBoxPergunta.Name = "groupBoxPergunta";
            groupBoxPergunta.Size = new Size(434, 111);
            groupBoxPergunta.TabIndex = 9;
            groupBoxPergunta.TabStop = false;
            groupBoxPergunta.Text = "Pergunta";
            // 
            // txtPergunta
            // 
            txtPergunta.Dock = DockStyle.Fill;
            txtPergunta.Location = new Point(3, 23);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ReadOnly = true;
            txtPergunta.Size = new Size(428, 85);
            txtPergunta.TabIndex = 0;
            txtPergunta.TabStop = false;
            // 
            // TelaDetalhesQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 669);
            Controls.Add(groupBoxPergunta);
            Controls.Add(BtnFechar);
            Controls.Add(groupAlternativas);
            Controls.Add(groupQuestao);
            Name = "TelaDetalhesQuestaoForm";
            Text = "TelaDetalhesQuestaoForm";
            groupQuestao.ResumeLayout(false);
            groupQuestao.PerformLayout();
            groupAlternativas.ResumeLayout(false);
            groupAlternativas.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxPergunta.ResumeLayout(false);
            groupBoxPergunta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupQuestao;
        private Label label2;
        private Label labelId;
        private GroupBox groupAlternativas;
        private Label label8;
        private Button BtnFechar;
        private Label labelSerie;
        private GroupBox groupBoxPergunta;
        private Label txtSerie;
        private Label txtMateria;
        private Label txtId;
        private Panel panel1;
        private ListBox listAlternativas;
        private TextBox txtPergunta;
        private TextBox txtCorreta;
    }
}