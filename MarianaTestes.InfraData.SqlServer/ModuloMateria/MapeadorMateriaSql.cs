using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using MarianaTestes.InfraData.SqlServer.ModuloDisciplina;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloMateria
{
    public class MapeadorMateriaSql : MapeadorBaseSql<Materia>
    {
        public override Materia ConverterParaObjeto(SqlDataReader leitor)
        {
            int id = Convert.ToInt32(leitor["ID_MATERIA"]);

            string nome = Convert.ToString(leitor["NOME_MATERIA"])!;

            SerieMateriaEnum serie = (SerieMateriaEnum)Convert.ToInt32(leitor["SERIE_MATERIA"]);

            MapeadorDisciplinaSql mapeadorDisciplinaSql = new MapeadorDisciplinaSql();

            Disciplina disciplina = mapeadorDisciplinaSql.ConverterParaObjeto(leitor);

            return new Materia(id, nome, serie, new List<Questao>(), disciplina);
        }

        public override void ConverterParaSql(SqlCommand comando, Materia entidade)
        {
            comando.Parameters.AddWithValue("NOME_MATERIA", entidade.Nome);
            comando.Parameters.AddWithValue("SERIE_MATERIA", entidade.Serie);          
            comando.Parameters.AddWithValue("ID_DISCIPLINA", entidade.Disciplina.Id);
        }
    }
}
