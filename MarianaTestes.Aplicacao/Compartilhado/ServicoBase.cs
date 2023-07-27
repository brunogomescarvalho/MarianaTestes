using MarianaTestes.Dominio.Compartilhado;
using System.Data.SqlClient;

namespace MarianaTestes.Aplicacao.Compartilhado
{
    delegate void onEfetuarOperacao<TEntidade>(TEntidade entidade);
    public abstract class ServicoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected IRepositorioBase<TEntidade> _repositorioBase = null!;

        protected abstract IEnumerable<string> ValidarCadastro(TEntidade entidade);

        public virtual Result Inserir(TEntidade entidade)
        {
            return EfetuarOperacao(_repositorioBase.Cadastrar, entidade);
        }

        public virtual Result Editar(TEntidade entidade)
        {
            return EfetuarOperacao(_repositorioBase.Editar, entidade);
        }

        public virtual Result Excluir(TEntidade entidade)
        {
            try
            {
                return EfetuarOperacao(_repositorioBase.Excluir, entidade);
            }
            catch (Exception)
            {
                return Result.Fail($"Não foi possível excluir a {typeof(TEntidade).Name} - Id: {entidade.Id}, pois existem outros cadastros relacionados a ela.");
            }
        }


        private Result EfetuarOperacao(onEfetuarOperacao<TEntidade> onEfetuarOperacao_, TEntidade entidade)
        {
            List<string> erros = ValidarCadastro(entidade).ToList();

            string msg = $"Tentando {onEfetuarOperacao_.Method.Name} {typeof(TEntidade).Name} - {entidade}";

            Log.Debug(msg);

            if (erros.Any())
            {
                erros.ForEach(i => Log.Warning(i, entidade.Id));

                return Result.Fail(erros);
            }

            try
            {
                onEfetuarOperacao_(entidade);

                msg = $"Solicitação {onEfetuarOperacao_.Method.Name} {typeof(TEntidade).Name} - {entidade} Id: {entidade.Id} efetuada com sucesso!";

                Log.Debug(msg);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                string erro = $"Falha ao tentar {onEfetuarOperacao_.Method.Name} {typeof(TEntidade).Name} - {entidade} Id: {entidade.Id}";

                Log.Error(ex, $"{erro} - {ex.Message}", entidade);

                return Result.Fail(erro);
            }

        }
    }
}
