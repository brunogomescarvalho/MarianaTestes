namespace MarianaTestes.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        public int Id { get; set; }

        public abstract void Editar(TEntidade entidade);

      
    }
}
