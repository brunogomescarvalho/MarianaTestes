namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    partial class TelaDetalhesTeste
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
            panel1 = new Panel();
            textBox = new RichTextBox();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 410);
            panel1.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 0);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(620, 410);
            textBox.TabIndex = 0;
            textBox.TabStop = false;
            textBox.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(493, 451);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 39);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "OK";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDetalhesTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 525);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Name = "TelaDetalhesTeste";
            Text = "Visualizar Teste";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private RichTextBox textBox;
    }
}