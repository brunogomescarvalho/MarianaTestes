using MarianaTestes.Dominio.ModuloDisciplina;

namespace MarianaTestes.Aplicacao.ModuloDisciplina
{
    public class ServicoDisciplina : ServicoBase<Disciplina>
    {       
        IRepositorioDisciplina repositorioDisciplina;

        IValidadorDisciplina validadorDisciplina;

        public ServicoDisciplina(IRepositorioDisciplina repositorioDisciplina, IValidadorDisciplina validadorDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            _repositorioBase = repositorioDisciplina;
            this.validadorDisciplina = validadorDisciplina;
        }

        protected override IEnumerable<string> ValidarCadastro(Disciplina entidade)
        {
            var resultadoValidacao = validadorDisciplina.Validate(entidade);

            List<string> erros = new();

            if(resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(i => i.ErrorMessage).ToList());

            var disciplinaEncontrada = repositorioDisciplina.BuscarDisciplinaPorNome(entidade?.Nome!);

            if (disciplinaEncontrada == null)
                return erros;

             if(disciplinaEncontrada.Id != entidade!.Id && disciplinaEncontrada.Nome == entidade.Nome)
                erros.Add($"Já existe uma disciplina com o nome '{entidade.Nome}' cadastrado no sistema.");

            return erros;
        }
    }
}
