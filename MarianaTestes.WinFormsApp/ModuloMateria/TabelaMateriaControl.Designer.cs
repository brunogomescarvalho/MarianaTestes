namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    partial class TabelaMateriaControl
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
            dataGridMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMateria).BeginInit();
            SuspendLayout();
            // 
            // dataGridMateria
            // 
            dataGridMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMateria.Dock = DockStyle.Fill;
            dataGridMateria.Location = new Point(0, 0);
            dataGridMateria.Name = "dataGridMateria";
            dataGridMateria.RowTemplate.Height = 25;
            dataGridMateria.Size = new Size(667, 339);
            dataGridMateria.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridMateria);
            Name = "TabelaMateriaControl";
            Size = new Size(667, 339);
            ((System.ComponentModel.ISupportInitialize)dataGridMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMateria;
    }
}
