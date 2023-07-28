using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.InfraData.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace MarianaTestes.InfraData.Orm.ModuloMateria
{
    public class RepositorioMateriaOrm : RepositorioBase<Materia>, IRepositorioMateria

    {
        public RepositorioMateriaOrm(DbContext contexto) : base(contexto)
        {
        }

        public Materia BuscarQuestoesDaMateria(Materia materia)
        {
            return _registros
                .Include(m => m.Questoes.Where(q => q.Utilizada.Equals(false)))
                .SingleOrDefault(m => m.Equals(materia))!;
        }

        public Materia BuscarPorNome(string nome)
        {
            return _registros.SingleOrDefault(m => m.Nome == nome)!;
        }

        public List<Materia> BuscarTodos(bool carregarQuestoes = false, bool carregarAlternativas = false)
        {
            if (carregarQuestoes)
                return _registros
                    .Include(m => m.Questoes)
                    .Include(m => m.Disciplina)
                    .ToList();

            return _registros
                  .Include(m => m.Disciplina)
                  .ToList();
        }

        public List<Materia> FiltrarPorDisciplina(int idDisciplina)
        {
            return _registros
                .Include(m => m.Disciplina)
                .Where(m => m.Disciplina.Id == idDisciplina)
                .ToList();
        }
    }
}
