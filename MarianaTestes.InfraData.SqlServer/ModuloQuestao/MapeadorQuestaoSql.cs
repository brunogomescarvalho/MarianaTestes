using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using MarianaTestes.InfraData.SqlServer.ModuloMateria;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloQuestao
{
    public class MapeadorQuestaoSql : MapeadorBaseSql<Questao>
    {
        public override Questao ConverterParaObjeto(SqlDataReader leitor)
        {
            int id = Convert.ToInt32(leitor["ID_QUESTAO"]);

            string pergunta = Convert.ToString(leitor["PERGUNTA"])!;

            MapeadorMateriaSql mapeadorMateria = new MapeadorMateriaSql();

            Materia materia = mapeadorMateria.ConverterParaObjeto(leitor);

            return new Questao(id, pergunta,materia);
        }

        public override void ConverterParaSql(SqlCommand comando, Questao entidade)
        {

            comando.Parameters.AddWithValue("PERGUNTA", entidade.Pergunta);
            comando.Parameters.AddWithValue("MATERIA_ID", entidade.Materia.Id) ;

        }
    }
}
