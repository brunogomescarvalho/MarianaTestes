using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace MarianaTestes.InfraData.Orm.ModuloTeste
{
    public class RepositorioTesteOrm : RepositorioBase<Teste>, IRepositorioTeste
    {
        public RepositorioTesteOrm(DbContext contexto) : base(contexto)
        {
        }

        public Teste BuscarTestePorTitulo(string titulo)
        {
            return _registros.SingleOrDefault(t => t.Titulo == titulo)!;
        }

        public List<Teste> BuscarTodos(bool carregarQuestoes = false)
        {
            if (carregarQuestoes)
                return _registros

                    .Include(x => x.Materia)
                    .Include(x => x.Disciplina)
                    .Include(t => t.Questoes)
                    .ThenInclude(q => q.Alternativas)
                    .ToList();

            return _registros.ToList();
        }

        public List<Teste> FiltrarTestes(FiltroTeste filtro)
        {
            IQueryable<Teste> registros = null!;

            switch (filtro.Tipo)
            {
                case FiltroDeTeste.Materia:
                    registros = _registros.Where(t => t.Materia.Id == filtro.Id);
                    break;
                case FiltroDeTeste.Serie:
                    registros = _registros.Where(t => t.Serie == filtro.Serie);
                    break;
                case FiltroDeTeste.Disciplina:
                    registros = _registros.Where(t => t.Disciplina.Id == filtro.Id);
                    break;
                case FiltroDeTeste.Data:
                    registros = _registros
                        .Where(t => t.DataTeste >= filtro.DataInicial)
                        .Where(t => t.DataTeste <= filtro.DataFinal);
                    break;
                case FiltroDeTeste.Todos:
                    registros = _registros;
                    break;
            }

            return registros
                      .Include(x => x.Materia)
                      .Include(x => x.Disciplina)
                      .Include(t => t.Questoes)
                      .ThenInclude(q => q.Alternativas).ToList();

        }

        public Teste SelecionarPorId(int id, bool incluirQuestoes = false, bool incluirAlternativas = false, bool incluirMateria = false)
        {
            if (incluirQuestoes && incluirAlternativas)
                return _registros
                    .Include(x => x.Questoes)
                    .ThenInclude(x => x.Alternativas)
                    .FirstOrDefault(x => x.Id == id)!;

            else if (incluirQuestoes)
                return _registros
                    .Include(x => x.Questoes)
                    .FirstOrDefault(x => x.Id == id)!;

            return _registros.FirstOrDefault(x => x.Id == id)!;
        }
    }
}
