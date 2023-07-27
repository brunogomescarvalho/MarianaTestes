using MarianaTestes.Dominio.Compartilhado;


namespace MarianaTestes.Dominio.ModuloDisciplina
{


    public interface IRepositorioDisciplina : IRepositorioBase<Disciplina>
    {
        Disciplina BuscarDisciplinaPorNome(string nome);

        List<Disciplina> BuscarTodos(bool buscarMaterias = false);
    }
}
