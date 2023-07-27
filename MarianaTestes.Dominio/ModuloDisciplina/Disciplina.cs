using MarianaTestes.Dominio.Compartilhado;
using MarianaTestes.Dominio.ModuloMateria;

namespace MarianaTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; } = string.Empty;

        public List<Materia> Materias { get; set; }

        public Disciplina()
        {
            Materias = new List<Materia>();
        }

        public Disciplina(string nome) : this()
        {
            Nome = nome;
        }

        public Disciplina(string nome, List<Materia> materias) : this(nome)
        {
            Materias = materias;
        }

        public Disciplina(int id, string nome, List<Materia> materias) : this(nome, materias)
        {
            Id = id;
        }

        public void AdicionarMateria(Materia materia)
        {
            if (this.Materias.Contains(materia))
                return;

            this.Materias.Add(materia);
        }

        public override void Editar(Disciplina entidade)
        {
            this.Nome = entidade.Nome;
        }


        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Disciplina disciplina &&
                   Id == disciplina.Id &&
                   Nome == disciplina.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Materias, Nome);
        }
    }
}
