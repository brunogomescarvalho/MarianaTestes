namespace MarianaTestes.WinFormsApp.Compartilhado
{
    public class Configuracao
    {
        public string ToolTipInserir { get; set; } = string.Empty;
        public string ToolTipEditar { get; set; } = string.Empty;
        public string ToolTipExcluir { get; set; } = string.Empty;
        public string ToolTipFiltrar { get; set; } = string.Empty;
        public string ToolTipDuplicar { get; set; } = string.Empty;
        public string ToolTipDetalhes { get; set; } = string.Empty;
        public string ToolTipGerarPdf { get; set; } = string.Empty;
        public bool BtnAdicionarEnabled { get; set; }
        public bool BtnEditarEnabled { get; set; }
        public bool BtnExcluirEnabled { get; set; }
        public bool BtnFiltrarEnabled { get; set; }
        public bool BtnDetalhesEnabled { get; set; }
        public bool BtnDuplicarEnabled { get; set; }
        public bool BtnGerarPdfEnable { get; set; }

        public Configuracao(string toolTipInserir, string toolTipEditar, string toolTipExcluir)
        {
            ToolTipInserir = toolTipInserir;
            ToolTipEditar = toolTipEditar;
            ToolTipExcluir = toolTipExcluir;
           
            BtnAdicionarEnabled = true;
            BtnEditarEnabled = true;
            BtnExcluirEnabled = true;

        }
    }
}
