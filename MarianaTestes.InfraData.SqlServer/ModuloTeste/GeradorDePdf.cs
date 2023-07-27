using Aspose.Pdf;
using Aspose.Pdf.Text;
using MarianaTestes.Dominio.ModuloTeste;

namespace MarianaTestes.InfraData.SqlServer.ModuloTeste
{
    public class GeradorDePdf : IGeradorDePdf
    {

        private string? caminhoDiretorio;

        private readonly string downloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

        public GeradorDePdf(string caminhoDiretorio)
        {
            this.caminhoDiretorio = caminhoDiretorio;
        }

        public void GerarPDF(Teste teste, bool gabarito = false)
        {
            string nomeArquivo = $"{(gabarito ? "Gabarito" : "Teste")}N°{teste.Id}";

            Document document = new Document();

            Page page = document.Pages.Add();

            page.Paragraphs.Add(new TextFragment(teste.ObterTesteString(gabarito)));

            string pastaDownloads = AtribuirCaminho();

            string caminhoCompleto = Path.Combine(pastaDownloads, $"{nomeArquivo}.pdf");

            document.Save(caminhoCompleto);
        }

        private bool SalvarCaminhoPadrao()
        {
            return caminhoDiretorio == null;
        }

        private string AtribuirCaminho()
        {
            return SalvarCaminhoPadrao() ? downloads : caminhoDiretorio!;
        }
    }
}
