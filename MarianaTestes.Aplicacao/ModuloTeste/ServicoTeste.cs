using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;

namespace MarianaTestes.Aplicacao.ModuloTeste
{
    public class ServicoTeste : ServicoBase<Teste>
    {
        IRepositorioTeste repositorioTeste;
        IRepositorioQuestao repositorioQuestao;
        ValidadorTeste validadorTeste;

        public ServicoTeste(IRepositorioTeste repositorioTeste, ValidadorTeste validadorTeste, IRepositorioQuestao repositorioQuestao)
        {
            this.validadorTeste = validadorTeste;
            this.repositorioTeste = repositorioTeste;
            _repositorioBase = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
        }

        protected override IEnumerable<string> ValidarCadastro(Teste entidade)
        {
            List<string> erros = validadorTeste.Validate(entidade).Errors.Select(x => x.ErrorMessage).ToList();

            Teste testeEncontrado = repositorioTeste.BuscarTestePorTitulo(entidade.Titulo);

            if (testeEncontrado == null)
                return erros;

            if (testeEncontrado.Titulo == entidade.Titulo && testeEncontrado.Id != entidade.Id)
            {
                erros.Add($"O título '{entidade.Titulo}' já foi utilizado em outro teste");
            }

            return erros;
        }

        public override Result Inserir(Teste entidade)
        {
            var result = base.Inserir(entidade);

            if (result.IsSuccess)
            {
                entidade.Questoes.ForEach(q =>
                {
                    q.AlterarStatus();
                    repositorioQuestao.Editar(q);
                });
            }

            return result;

        }

        public override Result Excluir(Teste entidade)
        {
            var result = base.Excluir(entidade);

            if (result.IsSuccess)
            {
                entidade.Questoes.ForEach(q =>
                {
                    q.AlterarStatus();
                    repositorioQuestao.Editar(q);
                });
            }

            return result;
        }
    }
}




