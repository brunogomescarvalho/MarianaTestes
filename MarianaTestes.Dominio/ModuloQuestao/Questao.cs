using MarianaTestes.Dominio.Compartilhado;
using MarianaTestes.Dominio.ModuloMateria;

namespace MarianaTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string Pergunta { get; set; }

        public List<Alternativa> Alternativas { get; set; }

        public Materia Materia { get; set; }

        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }

        public Questao(int id, string pergunta, Materia materia):this(pergunta, materia)
        {
            Id = id;
            Pergunta = pergunta;
            Materia = materia;

        }

        public Questao(string pergunta, Materia materia):this()
        {
            Pergunta = pergunta;
            Materia = materia;
           
        }

        public void AdicionarAlternativa(Alternativa alternativa)
        {
            Alternativas.Add(alternativa);
        }

        public override void Editar(Questao entidade)
        {
            Pergunta = entidade.Pergunta;
            Alternativas = entidade.Alternativas;
            Materia = entidade.Materia;
        }

        public override string ToString()
        {
            return Pergunta;
        }


        public override bool Equals(object? obj)
        {
            return obj is Questao questao &&
                   Id == questao.Id &&
                   Pergunta == questao.Pergunta &&
                   EqualityComparer<Materia>.Default.Equals(Materia, questao.Materia);
        }
    }

    public enum FiltroDeQuestao
    {
        Todas, Materia, NaoUtilizadas
    }

}
