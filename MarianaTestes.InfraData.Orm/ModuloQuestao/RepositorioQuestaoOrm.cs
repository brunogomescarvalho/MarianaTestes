using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.InfraData.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace MarianaTestes.InfraData.Orm.ModuloQuestao
{
    public class RepositorioQuestaoOrm : RepositorioBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoOrm(DbContext contexto) : base(contexto)
        {
        }

        public List<Questao> BuscarQuestoesNaoUtilizadas()
        {
            return _registros.Include(q => q.Materia).Where(q => q.Utilizada == false).ToList();
        }

        public List<Questao> BuscarQuestoesProvaRecuperacao(int idDisciplina, SerieMateriaEnum serie)
        {
            return _registros
                .Include(q => q.Materia)
                .Where(q => q.Utilizada == false)
                .Where(q => q.Materia.Serie == serie)
                .Where(q => q.Materia.Disciplina.Id == idDisciplina)
                .ToList();
        }

        public List<Questao> BuscarQuestoesUtilizadas()
        {
            return _registros
                .Include(q => q.Materia).Where(q => q.Utilizada == true)
                .ToList();
        }

        public List<Questao> BuscarTodos(bool carregarAlternativas = false)
        {

            if (carregarAlternativas)
                return _registros
                       .Include(q => q.Materia)
                       .Include(q => q.Alternativas)
                       .ToList();

            return _registros.Include(q => q.Materia).ToList();
        }

        public List<Questao> FiltrarQuestoesPorMateria(Materia materia)
        {
            return _registros
                .Include(q => q.Materia)
                .Where(q => q.Materia.Equals(materia))
                .ToList();
        }

        public Questao BuscarPorId(int id, bool carregarAlternativas = false)
        {
            if (carregarAlternativas)
                return _registros
                       .Include(q => q.Materia)
                       .Include(q => q.Alternativas)
                       .SingleOrDefault(q => q.Id == id)!;

            return _registros
                .Include(q => q.Materia)
                .SingleOrDefault(q => q.Id == id)!;
        }


    }
}
