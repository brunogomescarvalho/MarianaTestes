namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    partial class TabelaQuestaoControl
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
            dataGridQuestao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridQuestao).BeginInit();
            SuspendLayout();
            // 
            // dataGridQuestao
            // 
            dataGridQuestao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridQuestao.Dock = DockStyle.Fill;
            dataGridQuestao.Location = new Point(0, 0);
            dataGridQuestao.Name = "dataGridQuestao";
            dataGridQuestao.RowTemplate.Height = 25;
            dataGridQuestao.Size = new Size(493, 314);
            dataGridQuestao.TabIndex = 0;
            // 
            // TabelaQuestaoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridQuestao);
            Name = "TabelaQuestaoControl";
            Size = new Size(493, 314);
            ((System.ComponentModel.ISupportInitialize)dataGridQuestao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridQuestao;
    }
}
