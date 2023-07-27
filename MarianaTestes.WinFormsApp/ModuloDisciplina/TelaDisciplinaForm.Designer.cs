namespace MarianaTestes.WinFormsApp.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            btnCadastrarDisciplina = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            textDisciplina = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrarDisciplina
            // 
            btnCadastrarDisciplina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrarDisciplina.DialogResult = DialogResult.OK;
            btnCadastrarDisciplina.Location = new Point(101, 223);
            btnCadastrarDisciplina.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarDisciplina.Name = "btnCadastrarDisciplina";
            btnCadastrarDisciplina.Size = new Size(86, 31);
            btnCadastrarDisciplina.TabIndex = 1;
            btnCadastrarDisciplina.Text = "Salvar";
            btnCadastrarDisciplina.UseVisualStyleBackColor = true;
            btnCadastrarDisciplina.Click += BtnCadastrarDisciplina_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(223, 223);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textDisciplina);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textID);
            groupBox1.Location = new Point(32, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 167);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Disciplina";
            // 
            // textDisciplina
            // 
            textDisciplina.Location = new Point(91, 100);
            textDisciplina.Margin = new Padding(3, 4, 3, 4);
            textDisciplina.Name = "textDisciplina";
            textDisciplina.Size = new Size(150, 27);
            textDisciplina.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 8;
            label2.Text = "Disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 54);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "Número:";
            // 
            // textID
            // 
            textID.Location = new Point(91, 47);
            textID.Margin = new Padding(3, 4, 3, 4);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new Size(76, 27);
            textID.TabIndex = 5;
            textID.TabStop = false;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 281);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrarDisciplina);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Disciplina";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarDisciplina;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox textDisciplina;
        private Label label2;
        private Label label1;
        private TextBox textID;
    }
}