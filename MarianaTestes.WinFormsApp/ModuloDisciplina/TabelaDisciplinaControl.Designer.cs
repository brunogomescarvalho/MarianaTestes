namespace MarianaTestes.WinFormsApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDisciplina).BeginInit();
            SuspendLayout();
            // 
            // dataGridDisciplina
            // 
            dataGridDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisciplina.Dock = DockStyle.Fill;
            dataGridDisciplina.Location = new Point(0, 0);
            dataGridDisciplina.Name = "dataGridDisciplina";
            dataGridDisciplina.RowTemplate.Height = 25;
            dataGridDisciplina.Size = new Size(465, 231);
            dataGridDisciplina.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridDisciplina);
            Name = "TabelaDisciplinaControl";
            Size = new Size(465, 231);
            ((System.ComponentModel.ISupportInitialize)dataGridDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDisciplina;
    }
}
