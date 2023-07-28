using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.InfraData.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace MarianaTestes.InfraData.Orm.ModuloDisciplina
{
    public class RepositorioDisciplinaOrm : RepositorioBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaOrm(DbContext contexto) : base(contexto)
        {
        }

        public Disciplina BuscarDisciplinaPorNome(string nome)
        {
            return _registros.SingleOrDefault(i => i.Nome == nome)!;
        }

        public Disciplina BuscarPorId(int id, bool carregarMaterias = false)
        {
            if (carregarMaterias)
                return _registros
                    .Include(d => d.Materias)
                    .ThenInclude(m => m.Questoes)
                    .SingleOrDefault(d => d.Id == id)!;

            return base.BuscarPorId(id);
        }

        public List<Disciplina> BuscarTodos(bool buscarMaterias = false)
        {
            if (buscarMaterias)
                return _registros
                    .Include(d => d.Materias)
                    .ThenInclude(m => m.Questoes)
                    .ToList();

            return _registros.ToList();
        }
    }
}
