
namespace MarianaTestes.Dominio.Compartilhado
{
    public interface IRepositorioBase<TEntidade> 
    {
        void Cadastrar(TEntidade entidade);

        void Editar(TEntidade entidade);

        void Excluir(int id);

        void Excluir(TEntidade entidade);

        TEntidade BuscarPorId(int id);

        List<TEntidade> BuscarTodos();

        
    }
}
