using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using System.Data.SqlClient;


namespace MarianaTestes.InfraData.SqlServer.ModuloDisciplina
{
    public class MapeadorDisciplinaSql : MapeadorBaseSql<Disciplina>
    {
        public override Disciplina ConverterParaObjeto(SqlDataReader leitor)
        {
            int id = Convert.ToInt32(leitor["DISCIPLINA_ID"]);

            string nome = Convert.ToString(leitor["DISCIPLINA_NOME"])!;

            return new Disciplina(id, nome, new List<Materia>());
        }

        public override void ConverterParaSql(SqlCommand comando, Disciplina entidade)
        {
            comando.Parameters.AddWithValue("NOME", entidade.Nome);
        }
    }
}
