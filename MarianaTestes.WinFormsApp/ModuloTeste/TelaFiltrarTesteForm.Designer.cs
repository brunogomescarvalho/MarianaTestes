namespace MarianaTestes.WinFormsApp.ModuloTeste
{
    partial class TelaFiltrarTesteForm
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
            txtOpcao = new ComboBox();
            label2 = new Label();
            txtTipo = new ComboBox();
            labelSelecione = new Label();
            dataGroup = new GroupBox();
            label1 = new Label();
            labelDataInicial = new Label();
            txtDataFinal = new DateTimePicker();
            txtDataInicial = new DateTimePicker();
            btnFiltrar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            dataGroup.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOpcao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTipo);
            groupBox1.Controls.Add(labelSelecione);
            groupBox1.Controls.Add(dataGroup);
            groupBox1.Location = new Point(25, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Testes";
            // 
            // txtOpcao
            // 
            txtOpcao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtOpcao.Enabled = false;
            txtOpcao.FormattingEnabled = true;
            txtOpcao.Location = new Point(30, 137);
            txtOpcao.Name = "txtOpcao";
            txtOpcao.Size = new Size(290, 28);
            txtOpcao.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 114);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "Selecione a Opção";
            // 
            // txtTipo
            // 
            txtTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTipo.FormattingEnabled = true;
            txtTipo.Location = new Point(30, 70);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(290, 28);
            txtTipo.TabIndex = 1;
            txtTipo.SelectedIndexChanged += TxtTipo_SelectedIndexChanged;
            // 
            // labelSelecione
            // 
            labelSelecione.AutoSize = true;
            labelSelecione.Location = new Point(30, 47);
            labelSelecione.Name = "labelSelecione";
            labelSelecione.Size = new Size(120, 20);
            labelSelecione.TabIndex = 1;
            labelSelecione.Text = "Selecione o Tipo";
            // 
            // dataGroup
            // 
            dataGroup.Controls.Add(label1);
            dataGroup.Controls.Add(labelDataInicial);
            dataGroup.Controls.Add(txtDataFinal);
            dataGroup.Controls.Add(txtDataInicial);
            dataGroup.Dock = DockStyle.Bottom;
            dataGroup.Enabled = false;
            dataGroup.Location = new Point(3, 197);
            dataGroup.Name = "dataGroup";
            dataGroup.Size = new Size(349, 127);
            dataGroup.TabIndex = 0;
            dataGroup.TabStop = false;
            dataGroup.Text = "Filtrar Por Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 41);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Data Término";
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.Location = new Point(27, 41);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new Size(81, 20);
            labelDataInicial.TabIndex = 2;
            labelDataInicial.Text = "Data Início";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(192, 76);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(125, 27);
            txtDataFinal.TabIndex = 4;
            // 
            // txtDataInicial
            // 
            txtDataInicial.Format = DateTimePickerFormat.Short;
            txtDataInicial.Location = new Point(27, 76);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(125, 27);
            txtDataInicial.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(164, 396);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 39);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += BtnFiltrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(286, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 39);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltrarTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 459);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(groupBox1);
            Name = "TelaFiltrarTesteForm";
            Text = "Filtrar Testes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            dataGroup.ResumeLayout(false);
            dataGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txtOpcao;
        private Label label2;
        private ComboBox txtTipo;
        private Label labelSelecione;
        private GroupBox dataGroup;
        private Label label1;
        private Label labelDataInicial;
        private DateTimePicker txtDataFinal;
        private DateTimePicker txtDataInicial;
        private Button btnFiltrar;
        private Button btnCancelar;
    }
}