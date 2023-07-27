namespace MarianaTestes.WinFormsApp.ModuloQuestao
{
    partial class TelaFiltrarQuestoesForm
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
            groupMateria = new GroupBox();
            comboMateria = new ComboBox();
            groupOpcaoBusca = new GroupBox();
            radioButtonMateria = new RadioButton();
            radioButtonTodas = new RadioButton();
            btnSalvar = new Button();
            btnCancelar = new Button();
            radioButtonNaoUtilizadas = new RadioButton();
            groupMateria.SuspendLayout();
            groupOpcaoBusca.SuspendLayout();
            SuspendLayout();
            // 
            // groupMateria
            // 
            groupMateria.Controls.Add(comboMateria);
            groupMateria.Location = new Point(25, 132);
            groupMateria.Name = "groupMateria";
            groupMateria.Size = new Size(368, 105);
            groupMateria.TabIndex = 0;
            groupMateria.TabStop = false;
            groupMateria.Text = "Selecione a Matéria";
            // 
            // comboMateria
            // 
            comboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(22, 46);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(318, 28);
            comboMateria.TabIndex = 2;
            // 
            // groupOpcaoBusca
            // 
            groupOpcaoBusca.Controls.Add(radioButtonNaoUtilizadas);
            groupOpcaoBusca.Controls.Add(radioButtonMateria);
            groupOpcaoBusca.Controls.Add(radioButtonTodas);
            groupOpcaoBusca.Location = new Point(25, 12);
            groupOpcaoBusca.Name = "groupOpcaoBusca";
            groupOpcaoBusca.Size = new Size(368, 104);
            groupOpcaoBusca.TabIndex = 1;
            groupOpcaoBusca.TabStop = false;
            groupOpcaoBusca.Text = "Opções de Busca";
            // 
            // radioButtonMateria
            // 
            radioButtonMateria.AutoSize = true;
            radioButtonMateria.Checked = true;
            radioButtonMateria.Location = new Point(22, 26);
            radioButtonMateria.Name = "radioButtonMateria";
            radioButtonMateria.Size = new Size(155, 24);
            radioButtonMateria.TabIndex = 1;
            radioButtonMateria.TabStop = true;
            radioButtonMateria.Tag = "materia";
            radioButtonMateria.Text = "Buscar por Matéria";
            radioButtonMateria.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodas
            // 
            radioButtonTodas.AutoSize = true;
            radioButtonTodas.Location = new Point(188, 26);
            radioButtonTodas.Name = "radioButtonTodas";
            radioButtonTodas.Size = new Size(152, 24);
            radioButtonTodas.TabIndex = 0;
            radioButtonTodas.TabStop = true;
            radioButtonTodas.Tag = "todas";
            radioButtonTodas.Text = "Todas as Questões";
            radioButtonTodas.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(179, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 37);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Filtrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(299, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 37);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoUtilizadas
            // 
            radioButtonNaoUtilizadas.AutoSize = true;
            radioButtonNaoUtilizadas.Location = new Point(22, 56);
            radioButtonNaoUtilizadas.Name = "radioButtonNaoUtilizadas";
            radioButtonNaoUtilizadas.Size = new Size(187, 24);
            radioButtonNaoUtilizadas.TabIndex = 2;
            radioButtonNaoUtilizadas.TabStop = true;
            radioButtonNaoUtilizadas.Text = "Questões não utilizadas";
            radioButtonNaoUtilizadas.UseVisualStyleBackColor = true;
            // 
            // TelaFiltrarQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 327);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupOpcaoBusca);
            Controls.Add(groupMateria);
            Name = "TelaFiltrarQuestoesForm";
            Text = "TelaFiltrarQuestoesForm";
            groupMateria.ResumeLayout(false);
            groupOpcaoBusca.ResumeLayout(false);
            groupOpcaoBusca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupMateria;
        private ComboBox comboMateria;
        private GroupBox groupOpcaoBusca;
        private RadioButton radioButtonMateria;
        private RadioButton radioButtonTodas;
        private Button btnSalvar;
        private Button btnCancelar;
        private RadioButton radioButtonNaoUtilizadas;
    }
}