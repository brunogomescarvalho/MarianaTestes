using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorioBase<Materia>
    {
        List<Materia> FiltrarPorDisciplina(int idDisciplina);

        List<Materia> BuscarTodos(bool carregarQuestoes = false, bool carregarAlternativas = false);

        Materia BuscarPorNome(string nome);

        Materia BuscarQuestoesDaMateria(Materia materia);
    }
}
