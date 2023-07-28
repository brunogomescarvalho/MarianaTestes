using MarianaTestes.Dominio.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace MarianaTestes.InfraData.Orm.Compartilhado
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase<T>
    {
        protected DbSet<T> _registros;

        protected readonly DbContext _dbContext;

        protected RepositorioBase(DbContext contexto)
        {
            _dbContext = contexto;

            _registros = _dbContext.Set<T>();
        }

        public void Cadastrar(T entidade)
        {
            _registros.Add(entidade);

            _dbContext.SaveChanges();

        }
        public T BuscarPorId(int id)
        {
            return _registros.SingleOrDefault(x => x.Id == id);
        }

        public List<T> BuscarTodos()
        {
            return _registros.ToList();
        }

        public void Editar(T entidade)
        {
            _registros.Update(entidade);

            _dbContext.SaveChanges();
        }

        public void Excluir(int id)
        {         
            _registros.Remove(BuscarPorId(id));

            _dbContext.SaveChanges();
        }

        public void Excluir(T entidade)
        {
            _registros.Remove(entidade);

            _dbContext.SaveChanges();
        }
    }
}
