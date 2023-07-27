namespace MarianaTestes.Dominio.ModuloTeste
{
    public interface IGeradorDePdf
    {
        void GerarPDF(Teste teste, bool gabarito = false);
    }
}
