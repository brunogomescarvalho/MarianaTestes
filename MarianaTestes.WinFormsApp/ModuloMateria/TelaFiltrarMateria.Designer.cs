namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    partial class TelaFiltrarMateria
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboDisciplina = new ComboBox();
            CheckBoxTodas = new CheckBox();
            btnFiltrar = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboDisciplina);
            groupBox1.Controls.Add(CheckBoxTodas);
            groupBox1.Location = new Point(28, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Matérias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Disciplina";
            // 
            // comboDisciplina
            // 
            comboDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDisciplina.FormattingEnabled = true;
            comboDisciplina.Location = new Point(33, 70);
            comboDisciplina.Name = "comboDisciplina";
            comboDisciplina.Size = new Size(250, 28);
            comboDisciplina.TabIndex = 1;
            // 
            // CheckBoxTodas
            // 
            CheckBoxTodas.AutoSize = true;
            CheckBoxTodas.Location = new Point(33, 117);
            CheckBoxTodas.Name = "CheckBoxTodas";
            CheckBoxTodas.Size = new Size(70, 24);
            CheckBoxTodas.TabIndex = 2;
            CheckBoxTodas.Text = "Todas";
            CheckBoxTodas.UseVisualStyleBackColor = true;
            CheckBoxTodas.CheckedChanged += CheckBoxTodas_CheckedChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(120, 233);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 38);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(240, 233);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // TelaFiltrarMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 298);
            Controls.Add(btnCancel);
            Controls.Add(btnFiltrar);
            Controls.Add(groupBox1);
            Name = "TelaFiltrarMateria";
            Text = "Filtrar Matérias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboDisciplina;
        private CheckBox CheckBoxTodas;
        private Button btnFiltrar;
        private Button btnCancel;
    }
}