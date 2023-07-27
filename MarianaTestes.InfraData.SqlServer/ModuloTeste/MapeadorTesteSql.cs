using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using MarianaTestes.InfraData.SqlServer.ModuloDisciplina;
using MarianaTestes.InfraData.SqlServer.ModuloMateria;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloTeste
{
    public class MapeadorTesteSql : MapeadorBaseSql<Teste>
    {
        public override Teste ConverterParaObjeto(SqlDataReader leitor)
        {
            int idTeste = Convert.ToInt32(leitor["TESTE_ID"]);
            string titulo = Convert.ToString(leitor["TESTE_TITULO"])!;
            DateTime dataTeste = Convert.ToDateTime(leitor["TESTE_DATA"]);
            int qtdQuestoes = Convert.ToInt32(leitor["TESTE_QTD_QUESTOES"]);
            SerieMateriaEnum serie = (SerieMateriaEnum)Convert.ToInt32(leitor["TESTE_SERIE"]);
            bool recuperacao = Convert.ToBoolean(leitor["TESTE_RECUPERACAO"]);

            Materia materia = null!;

            if (leitor["MATERIA_ID"] is not DBNull)
            {
                MapeadorMateriaSql mapeadorMateria = new MapeadorMateriaSql();

                materia = mapeadorMateria.ConverterParaObjeto(leitor);
            }

            MapeadorDisciplinaSql mapeadorDisciplina = new MapeadorDisciplinaSql();

            Disciplina disciplina = mapeadorDisciplina.ConverterParaObjeto(leitor);

            return new Teste(idTeste, titulo, disciplina, materia, qtdQuestoes, serie, dataTeste, recuperacao);

        }

        public override void ConverterParaSql(SqlCommand comando, Teste entidade)
        {

            comando.Parameters.AddWithValue("TESTE_DISCIPLINA_ID", entidade.Disciplina.Id);
            comando.Parameters.AddWithValue("TESTE_DATA", entidade.DataTeste);
            comando.Parameters.AddWithValue("TESTE_QTD_QUESTOES", entidade.Questoes.Count);
            comando.Parameters.AddWithValue("TESTE_SERIE", entidade.Serie);
            comando.Parameters.AddWithValue("TESTE_TITULO", entidade.Titulo);
            comando.Parameters.AddWithValue("TESTE_RECUPERACAO", entidade.Recuperacao);
            bool ehNulo = entidade.Materia == null!;
            comando.Parameters.AddWithValue("TESTE_MATERIA_ID", ehNulo ? DBNull.Value : entidade.Materia!.Id);


        }
    }
}
