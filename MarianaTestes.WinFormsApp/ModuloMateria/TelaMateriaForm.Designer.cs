namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            comboBoxDisciplina = new ComboBox();
            label1 = new Label();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            txtNomeMateria = new TextBox();
            label2 = new Label();
            label = new Label();
            label3 = new Label();
            txtIDMateria = new TextBox();
            comboBoxSerie = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxDisciplina
            // 
            comboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDisciplina.FormattingEnabled = true;
            comboBoxDisciplina.Location = new Point(105, 67);
            comboBoxDisciplina.Margin = new Padding(3, 4, 3, 4);
            comboBoxDisciplina.Name = "comboBoxDisciplina";
            comboBoxDisciplina.Size = new Size(260, 28);
            comboBoxDisciplina.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 71);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Disciplina";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalvar.DialogResult = DialogResult.OK;
            BtnSalvar.Location = new Point(169, 233);
            BtnSalvar.Margin = new Padding(3, 4, 3, 4);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(86, 31);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(279, 233);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 31);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNomeMateria
            // 
            txtNomeMateria.Location = new Point(105, 117);
            txtNomeMateria.Margin = new Padding(3, 4, 3, 4);
            txtNomeMateria.Name = "txtNomeMateria";
            txtNomeMateria.Size = new Size(260, 27);
            txtNomeMateria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 184);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Série";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(26, 125);
            label.Name = "label";
            label.Size = new Size(60, 20);
            label.TabIndex = 8;
            label.Text = "Matéria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 24);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 9;
            label3.Text = "ID";
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(105, 17);
            txtIDMateria.Margin = new Padding(3, 4, 3, 4);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.ReadOnly = true;
            txtIDMateria.Size = new Size(81, 27);
            txtIDMateria.TabIndex = 0;
            txtIDMateria.TabStop = false;
            // 
            // comboBoxSerie
            // 
            comboBoxSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSerie.FormattingEnabled = true;
            comboBoxSerie.Location = new Point(109, 176);
            comboBoxSerie.Name = "comboBoxSerie";
            comboBoxSerie.Size = new Size(255, 28);
            comboBoxSerie.TabIndex = 3;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 304);
            Controls.Add(comboBoxSerie);
            Controls.Add(txtIDMateria);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(txtNomeMateria);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(comboBoxDisciplina);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Matéria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDisciplina;
        private Label label1;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private TextBox txtNomeMateria;
        private Label label2;
        private Label label;
        private Label label3;
        private TextBox txtIDMateria;
        private ComboBox comboBoxSerie;
    }
}