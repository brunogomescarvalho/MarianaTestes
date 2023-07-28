using MarianaTestes.Dominio.Compartilhado;
using MarianaTestes.Dominio.ModuloMateria;

namespace MarianaTestes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorioBase<Questao>
    {

      

        List<Questao> BuscarQuestoesProvaRecuperacao(int idDisciplina, SerieMateriaEnum serie);

        List<Questao> BuscarTodos(bool carregarAlternativas = false);

        List<Questao> FiltrarQuestoesPorMateria(Materia materia);

        List<Questao> BuscarQuestoesNaoUtilizadas();

        List<Questao> BuscarQuestoesUtilizadas();

        Questao BuscarPorId(int id, bool carregarAlternativas = false);
    }
}
