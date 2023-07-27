using MarianaTestes.Dominio.ModuloTeste;

namespace MarianaTestes.Aplicacao.ModuloTeste
{
    public class ServicoTeste : ServicoBase<Teste>
    {
        IRepositorioTeste repositorioTeste;
        ValidadorTeste validadorTeste;

        public ServicoTeste(IRepositorioTeste repositorioTeste, ValidadorTeste validadorTeste)
        {
            this.validadorTeste = validadorTeste;
            this.repositorioTeste = repositorioTeste;
            _repositorioBase = repositorioTeste;
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
    }
}




