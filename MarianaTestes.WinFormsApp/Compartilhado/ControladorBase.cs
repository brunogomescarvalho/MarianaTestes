using FluentResults;
using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.WinFormsApp.Compartilhado
{
    public delegate Result onGravarRegistro<TEntidade>(TEntidade entidade) where TEntidade : EntidadeBase<TEntidade>;

    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract UserControl ObterListagem();
        public abstract void ConfigurarTela();
        public virtual void Filtrar() { }
        public virtual void ObterDetalhes() { }
        public abstract void AtualizarListagem();

        public Configuracao Configuracao = null!;

    }
}
