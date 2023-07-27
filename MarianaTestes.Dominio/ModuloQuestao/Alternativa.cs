
namespace MarianaTestes.Dominio.ModuloQuestao
{
    public class Alternativa
    {
        public Questao Questao { get; set; }

        public string? Texto { get; set; }

        public bool EhCorreta { get; set; }

        public int Id { get; set; }

        public Alternativa()
        {
            
        }
        public Alternativa(string? texto, bool ehCorreta, int id) : this(texto, ehCorreta)
        {
            Id = id;
        }


        public Alternativa(string? texto, bool ehCorreta)
        {
            Texto = texto;
            EhCorreta = ehCorreta;
        }


        public override string ToString()
        {
            return Texto!;
        }

        public bool Validar()
        {
            return string.IsNullOrEmpty(Texto) == false;
        }

        public override bool Equals(object? obj)
        {
            return obj is Alternativa alternativa &&             
                   Texto == alternativa.Texto &&
                   EhCorreta == alternativa.EhCorreta &&
                   Id == alternativa.Id;
        }
    }

}
