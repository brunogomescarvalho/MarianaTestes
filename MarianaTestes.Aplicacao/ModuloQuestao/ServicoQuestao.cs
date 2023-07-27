using MarianaTestes.Dominio.ModuloQuestao;

namespace MarianaTestes.Aplicacao.ModuloQuestao
{
    public class ServicoQuestao : ServicoBase<Questao>
    {
        ValidadorQuestao validadorQuestao;

        public ServicoQuestao(IRepositorioQuestao repositorioQuestao, ValidadorQuestao validadorQuestao)
        {
            this.validadorQuestao = validadorQuestao;
            _repositorioBase = repositorioQuestao;
        }

        protected override IEnumerable<string> ValidarCadastro(Questao entidade)
        {
            return validadorQuestao.Validate(entidade).Errors.Select(i => i.ErrorMessage).ToList();
        }

    }
}
