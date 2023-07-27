using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaTestes.WinFormsApp.ModuloMateria
{
    public partial class TelaFiltrarMateria : Form
    {
        public Disciplina disciplina;

        public TelaFiltrarMateria(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            comboDisciplina.DataSource = disciplinas;
        }

        private void CheckBoxTodas_CheckedChanged(object sender, EventArgs e)
        {
            comboDisciplina.Enabled = !CheckBoxTodas.Checked;
            comboDisciplina.SelectedItem = CheckBoxTodas.Checked ? null : comboDisciplina.Items[0];
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboDisciplina.SelectedItem != null)
            {
                this.disciplina = (Disciplina)comboDisciplina.SelectedItem;
            }
        }
    }
}
