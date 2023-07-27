
using MarianaTestes.Dominio.ModuloQuestao;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloQuestao
{
    public class MapeadorAlternativa
    {
        public Alternativa ConverterParaObjeto(SqlDataReader leitor)
        {
            int id = Convert.ToInt32(leitor["ALTERNATIVA_ID"]);

            string texto = Convert.ToString(leitor["ALTERNATIVA_TEXTO"])!;

            bool correta = Convert.ToBoolean(leitor["ALTERNATIVA_CORRETA"]);

            return new Alternativa(texto, correta,id);
        }


        public void ConverterParaSql(SqlCommand comando, Alternativa altenativa)
        {
            comando.Parameters.AddWithValue("TEXTO", altenativa.Texto);
            comando.Parameters.AddWithValue("CORRETA", altenativa.EhCorreta);
            comando.Parameters.AddWithValue("QUESTAO_ID", altenativa.Questao.Id);
        }
    }
}
