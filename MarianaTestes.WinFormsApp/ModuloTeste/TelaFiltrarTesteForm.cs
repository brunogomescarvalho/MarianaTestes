using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.WinFormsApp.Compartilhado;

namespace MarianaTestes.WinFormsApp.ModuloTeste;


public delegate object onEnviarTipoDeFiltro(FiltroDeTeste filtro);

public partial class TelaFiltrarTesteForm : Form
{
    public onEnviarTipoDeFiltro onEnviarTipoDeFiltro { get; set; }

    public FiltroTeste filtroTeste;

    public TelaFiltrarTesteForm()
    {
        InitializeComponent();

        this.ConfigurarDialog();

        Enum.GetValues<FiltroDeTeste>().ToList().ForEach(f => txtTipo.Items.Add(f));
    }

    private void TxtTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComboBox comboBox = (ComboBox)sender;

        FiltroDeTeste filtro = (FiltroDeTeste)comboBox.SelectedItem;

        dataGroup.Enabled = filtro == FiltroDeTeste.Data;

        txtOpcao.Enabled = filtro != FiltroDeTeste.Data;

        ConfigurarOpcoesFiltroSelecionado(onEnviarTipoDeFiltro(filtro));
    }

    public void ConfigurarOpcoesFiltroSelecionado(object itens)
    {
        txtOpcao.Items.Clear();

        FiltroDeTeste filtro = (FiltroDeTeste)txtTipo.SelectedItem;

        switch (filtro)
        {
            case FiltroDeTeste.Materia:
                List<Materia> materias = (List<Materia>)itens;
                materias.ForEach(m => txtOpcao.Items.Add(m));
                break;

            case FiltroDeTeste.Disciplina:
                List<Disciplina> disciplinas = (List<Disciplina>)itens;
                disciplinas.ForEach(d => txtOpcao.Items.Add(d));
                break;

            case FiltroDeTeste.Serie:
                Enum.GetValues<SerieMateriaEnum>().ToList().ForEach(f => txtOpcao.Items.Add(f));
                break;

            case FiltroDeTeste.Data:
                dataGroup.Enabled = true;
                break;

            case FiltroDeTeste.Todos:
                break;
        }
    }

    private void BtnFiltrar_Click(object sender, EventArgs e)
    {
        if (ValidarOpcaoValida() == false)
            return;

        FiltroDeTeste filtro = (FiltroDeTeste)txtTipo.SelectedItem;

        filtroTeste = new FiltroTeste();

        switch (filtro)
        {
            case FiltroDeTeste.Todos:
                filtroTeste.Tipo = FiltroDeTeste.Todos;
                break;

            case FiltroDeTeste.Materia:

                Materia materia = (Materia)txtOpcao.SelectedItem!;
                filtroTeste.Tipo = FiltroDeTeste.Materia;
                filtroTeste.Id = materia.Id;
                break;

            case FiltroDeTeste.Serie:

                SerieMateriaEnum serie = (SerieMateriaEnum)txtOpcao.SelectedItem!;
                filtroTeste.Tipo = FiltroDeTeste.Serie;
                filtroTeste.Serie = serie;
                break;

            case FiltroDeTeste.Disciplina:

                Disciplina disciplina = (Disciplina)txtOpcao.SelectedItem!;
                filtroTeste.Tipo = FiltroDeTeste.Disciplina;
                filtroTeste.Id = disciplina.Id;
                break;

            case FiltroDeTeste.Data:
                if (ValidarDataFiltro())
                {
                    filtroTeste.DataInicial = txtDataInicial.Value;
                    filtroTeste.DataFinal = txtDataFinal.Value;
                    filtroTeste.Tipo = FiltroDeTeste.Data;
                }
                else
                    TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape($"A data inicial não pode ser maior do que a final");
                break;
        }
    }

    private bool ValidarOpcaoValida()
    {
        if (txtOpcao.Enabled == true && txtOpcao.SelectedItem == null
            && (FiltroDeTeste)txtTipo.SelectedItem != FiltroDeTeste.Todos || txtTipo.SelectedItem == null)
        {
            DialogResult = DialogResult.None;
            TelaPrincipalForm.TelaPrincipal!
                .AlterarLabelRodape($"Selecione {(txtTipo.SelectedItem == null ? "o tipo de filtro" : $"a {txtTipo.Text} para filtrar")}");
            return false;
        }
        return true;
    }

    private bool ValidarDataFiltro()
    => txtDataInicial.Value < txtDataFinal.Value;
}