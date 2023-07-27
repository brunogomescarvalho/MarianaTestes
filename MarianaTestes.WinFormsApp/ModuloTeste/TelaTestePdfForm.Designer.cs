namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    partial class TelaTestePdfForm
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
            txtCaminho = new TextBox();
            BtnBuscar = new Button();
            BtnVisualizar = new Button();
            btnSalvar = new Button();
            button4 = new Button();
            groupCaminho = new GroupBox();
            label1 = new Label();
            CheckOpcao = new CheckBox();
            saveFile = new SaveFileDialog();
            groupCaminho.SuspendLayout();
            SuspendLayout();
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(20, 56);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.ReadOnly = true;
            txtCaminho.Size = new Size(409, 27);
            txtCaminho.TabIndex = 2;
            txtCaminho.TabStop = false;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(298, 21);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(131, 29);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnVisualizar
            // 
            BtnVisualizar.Location = new Point(12, 178);
            BtnVisualizar.Name = "BtnVisualizar";
            BtnVisualizar.Size = new Size(117, 40);
            BtnVisualizar.TabIndex = 3;
            BtnVisualizar.Text = "Visualizar";
            BtnVisualizar.UseVisualStyleBackColor = true;
            BtnVisualizar.Click += BtnVisualizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(135, 178);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(223, 40);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(364, 178);
            button4.Name = "button4";
            button4.Size = new Size(94, 40);
            button4.TabIndex = 5;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupCaminho
            // 
            groupCaminho.Controls.Add(label1);
            groupCaminho.Controls.Add(txtCaminho);
            groupCaminho.Controls.Add(BtnBuscar);
            groupCaminho.Enabled = false;
            groupCaminho.Location = new Point(12, 53);
            groupCaminho.Name = "groupCaminho";
            groupCaminho.Size = new Size(446, 102);
            groupCaminho.TabIndex = 6;
            groupCaminho.TabStop = false;
            groupCaminho.Text = "Selecione o destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Caminho da Pasta";
            // 
            // CheckOpcao
            // 
            CheckOpcao.AutoSize = true;
            CheckOpcao.Checked = true;
            CheckOpcao.CheckState = CheckState.Checked;
            CheckOpcao.Location = new Point(12, 12);
            CheckOpcao.Name = "CheckOpcao";
            CheckOpcao.Size = new Size(175, 24);
            CheckOpcao.TabIndex = 7;
            CheckOpcao.Text = "Salvar Em Downloads";
            CheckOpcao.UseVisualStyleBackColor = true;
            CheckOpcao.CheckedChanged += CheckOpcao_CheckedChanged;
            // 
            // TelaTestePdfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 243);
            Controls.Add(CheckOpcao);
            Controls.Add(groupCaminho);
            Controls.Add(button4);
            Controls.Add(btnSalvar);
            Controls.Add(BtnVisualizar);
            Name = "TelaTestePdfForm";
            Text = "Salvar Pdf";
            groupCaminho.ResumeLayout(false);
            groupCaminho.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCaminho;
        private Button BtnBuscar;
        private Button BtnVisualizar;
        private Button btnSalvar;
        private Button button4;
        private GroupBox groupCaminho;
        private Label label1;
        private CheckBox CheckOpcao;
        private SaveFileDialog saveFile;
    }
}