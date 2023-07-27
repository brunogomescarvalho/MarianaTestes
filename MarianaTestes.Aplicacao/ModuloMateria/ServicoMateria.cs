using MarianaTestes.Dominio.ModuloMateria;

namespace MarianaTestes.Aplicacao.ModuloMateria
{
    public class ServicoMateria : ServicoBase<Materia>
    {
        IRepositorioMateria repositorioMateria;

        ValidadorMateria validadorMateria;

        public ServicoMateria(IRepositorioMateria repositorioMateria, ValidadorMateria validadorMateria)
        {
            this.validadorMateria = validadorMateria;
            this.repositorioMateria = repositorioMateria;
            this._repositorioBase = repositorioMateria;
        }

        protected override IEnumerable<string> ValidarCadastro(Materia materia)
        {
            List<string> erros = validadorMateria.Validate(materia).Errors.Select(i => i.ErrorMessage).ToList();

            if (MateriaJaExiste(materia))
                erros.Add($"Já existe uma matéria com o nome '{materia.Nome}' na '{materia.Serie}' série cadastrada no sistema");

            return erros;
        }

        private bool MateriaJaExiste(Materia materia)
        {
            var materiaEncontrada = repositorioMateria.BuscarPorNome(materia.Nome);

            if (materiaEncontrada == null)
                return false;

            return materiaEncontrada.Nome == materia.Nome &&
                            materiaEncontrada.Serie == materia.Serie &&
                            materiaEncontrada.Id != materia.Id;
        }
    }
}
