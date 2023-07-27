using MarianaTestes.Dominio.ModuloMateria;

namespace MarianaTestes.Dominio.ModuloTeste
{
    public class FiltroTeste
    {
        public FiltroDeTeste Tipo { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int Id { get; set; }
        public SerieMateriaEnum Serie { get; set; }
    }

    public enum FiltroDeTeste
    {
        Materia, Serie, Disciplina, Data, Todos
    }
}