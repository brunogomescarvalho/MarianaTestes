using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using MarianaTestes.InfraData.SqlServer.ModuloQuestao;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloTeste
{
    public class RepositorioTesteSql : RepositorioBaseSql<Teste, MapeadorTesteSql>, IRepositorioTeste
    {
        public RepositorioTesteSql(string connectionString) : base(connectionString)
        {
        }

        protected override string SqlBuscarPorId => ObterQueryBuscarPorId();

        protected override string SqlBuscarTodos => ObterQueryBuscarTodos();

        protected override string SqlCadastrar => ObterQueryCadastrar();

        protected override string SqlEditar => null!;

        protected override string SqlExcluir => ObterQueryExcluir();



        public override void Cadastrar(Teste teste)
        {
            base.Cadastrar(teste);

            foreach (Questao item in teste.Questoes)
            {
                CadastrarQuestao(item, teste);
            }
        }

        public override Teste BuscarPorId(int id)
        {
            Teste teste = base.BuscarPorId(id);

            teste.AdicionarQuestoes(BuscarQuestoes(teste.Id));

            foreach (Questao item in teste.Questoes)
            {
                item.Alternativas.AddRange(BuscarAlternativas(item.Id));
            }

            return teste;
        }

        public override void Excluir(Teste teste)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                using SqlCommand comando = conexao.CreateCommand();

                comando.CommandText = ObterQueryExcluirQuestoesTeste();

                comando.Parameters.AddWithValue("ID_TESTE", teste.Id);

                comando.ExecuteNonQuery();
            }
            base.Excluir(teste);
        }

        public List<Teste> BuscarTodos(bool carregarQuestoes = false)
        {
            List<Teste> testes = base.BuscarTodos();

            if (carregarQuestoes)
            {
                testes.ForEach(t => t.Questoes.AddRange(BuscarQuestoes(t.Id)));
            }

            return testes;
        }

        public List<Teste> FiltrarTestes(FiltroTeste filtro)
        {
            List<Teste> testes = new List<Teste>();

            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();

            ObterParametrosFiltro(filtro, comando);

            SqlDataReader leitor = comando.ExecuteReader();

            MapeadorTesteSql mapeadorTeste = new MapeadorTesteSql();

            while (leitor.Read())
            {
                Teste teste = mapeadorTeste.ConverterParaObjeto(leitor);

                testes.Add(teste);
            }

            return testes;

        }

        public Teste BuscarTestePorTitulo(string titulo)
        {
            List<SqlParameter> parametros = new() { new SqlParameter("TITULO_TESTE", titulo) };

            return BuscarPorParametros(parametros, ObterQueryBuscarPorNome());

        }

        private void CadastrarQuestao(Questao questao, Teste teste)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = ObterQueryCadastrarQuestoes();

            comando.Parameters.AddWithValue("ID_TESTE", teste.Id);
            comando.Parameters.AddWithValue("ID_QUESTAO", questao.Id);

            comando.ExecuteNonQuery();
        }

        private void ObterParametrosFiltro(FiltroTeste filtro, SqlCommand comando)
        {
            switch (filtro.Tipo)
            {
                case FiltroDeTeste.Todos:
                    comando.CommandText = ObterQueryBuscarTodos();
                    break;
                case FiltroDeTeste.Materia:
                    comando.CommandText = ObterQueryBuscarPorMateria();
                    comando.Parameters.AddWithValue("ID_MATERIA", filtro.Id);
                    break;
                case FiltroDeTeste.Disciplina:
                    comando.CommandText = ObterQueryBuscarPorDisciplina();
                    comando.Parameters.AddWithValue("ID_DISCIPLINA", filtro.Id);
                    break;
                case FiltroDeTeste.Serie:
                    comando.CommandText = ObterQueryBuscarPorSerie();
                    comando.Parameters.AddWithValue("SERIE", filtro.Serie);
                    break;
                case FiltroDeTeste.Data:
                    comando.CommandText = ObterQueryFiltrarPorData();
                    comando.Parameters.AddWithValue("DATA_INICIAL", filtro.DataInicial);
                    comando.Parameters.AddWithValue("DATA_FINAL", filtro.DataFinal);
                    break;
            }
        }

        private List<Questao> BuscarQuestoes(int testeId)
        {
            List<SqlParameter> parametros = new List<SqlParameter>() { new SqlParameter("ID_TESTE", testeId) };

            MapeadorQuestaoSql mapeador = new MapeadorQuestaoSql();

            return SelecionarRegistros(ObterQueryBuscarQuestoes(), parametros, mapeador.ConverterParaObjeto);

        }

        private List<Alternativa> BuscarAlternativas(int idQuestao)
        {
            List<SqlParameter> parametros = new List<SqlParameter>() { new SqlParameter("QUESTAO_ID", idQuestao) };

            MapeadorAlternativa mapeador = new MapeadorAlternativa();

            return SelecionarRegistros(ObterQueryBuscarAlternativas(), parametros, mapeador.ConverterParaObjeto);

        }

        private string ObterQueryExcluirQuestoesTeste()
        {
            return @"DELETE FROM TB_TESTE_TB_QUESTAO WHERE TB_TESTE_TB_QUESTAO.ID_TESTE = @ID_TESTE";
        }

        private string ObterQueryBuscarPorNome()
        {
            return ObterQueryBuscarTodos() + "  WHERE T.TITULO = @TITULO_TESTE";
        }

        private string ObterQueryBuscarQuestoesJaUtilizadas()
        {
            return @"SELECT FROM TB_QUESTAO Q INNER JOIN TB_TESTE_TB_QUESTAO TQ ON (Q.ID = TQ.ID_QUESTAO)";
        }

        private string ObterQueryBuscarPorId()
        {
            return ObterQueryBuscarTodos() + @"WHERE T.ID = @ID";
        }

        private string ObterQueryExcluir()
        {
            return @"DELETE FROM TB_TESTE WHERE ID = @ID;";
        }

        private string ObterQueryBuscarPorMateria()
        {
            return ObterQueryBuscarTodos() + " WHERE M.ID = @ID_MATERIA";
        }

        private string ObterQueryBuscarPorSerie()
        {
            return ObterQueryBuscarTodos() + " WHERE T.SERIE = @SERIE";
        }

        private string ObterQueryBuscarPorDisciplina()
        {
            return ObterQueryBuscarTodos() + " WHERE D.ID = @ID_DISCIPLINA";
        }

        private string ObterQueryFiltrarPorData()
        {
            return ObterQueryBuscarTodos() + " WHERE T.DATA_TESTE BETWEEN @DATA_INICIAL AND @DATA_FINAL";
        }

        private string ObterQueryCadastrarQuestoes()
        {
            return @"INSERT INTO 
            [TB_TESTE_TB_QUESTAO]

            ([ID_TESTE]
            ,[ID_QUESTAO])

            VALUES
            (@ID_TESTE
            ,@ID_QUESTAO)";
        }

        private string ObterQueryBuscarAlternativas()
        {
            return @"SELECT 
             A.ID       ALTERNATIVA_ID
            ,A.TEXTO    ALTERNATIVA_TEXTO
            ,A.CORRETA  ALTERNATIVA_CORRETA
            FROM 
            TB_ALTERNATIVA A 
            WHERE 
            A.QUESTAO_ID = @QUESTAO_ID";
        }


        private string ObterQueryCadastrar()
        {
            return @"INSERT INTO 
            [TB_TESTE](
                TITULO
            , DATA_TESTE
            , QUANTIDADE_QUESTOES
            , SERIE
            , DISCIPLINA_ID
            , RECUPERACAO
            , MATERIA_ID)

            VALUES (

                @TESTE_TITULO
            , @TESTE_DATA
            , @TESTE_QTD_QUESTOES
            , @TESTE_SERIE
            , @TESTE_DISCIPLINA_ID
            , @TESTE_RECUPERACAO
            , @TESTE_MATERIA_ID);

            SELECT SCOPE_IDENTITY();";
        }

        private string ObterQueryBuscarQuestoes()
        {
            return @" SELECT 

            Q.ID AS ID_QUESTAO
            ,Q.PERGUNTA

            ,M.ID ID_MATERIA
            ,M.NOME NOME_MATERIA
            ,M.SERIE SERIE_MATERIA

            ,D.ID DISCIPLINA_ID
            ,D.NOME DISCIPLINA_NOME
                   
            FROM TB_QUESTAO Q

            INNER JOIN 
            TB_MATERIA M
            ON (Q.MATERIA_ID = M.ID)

            INNER JOIN 
            TB_DISCIPLINA D
            ON (D.ID = M.DISCIPLINA_ID)

            INNER JOIN 
            TB_TESTE_TB_QUESTAO TQ
            ON (TQ.ID_QUESTAO = Q.ID)

            WHERE TQ.ID_TESTE = @ID_TESTE";
        }


        private string ObterQueryBuscarTodos()
        {
            return @" SELECT
            T.ID                    TESTE_ID,
            T.RECUPERACAO           TESTE_RECUPERACAO,
            T.TITULO                TESTE_TITULO,
            T.DATA_TESTE            TESTE_DATA,
            T.QUANTIDADE_QUESTOES   TESTE_QTD_QUESTOES,
            T.SERIE                 TESTE_SERIE,
            T.MATERIA_ID            MATERIA_ID,

            D.ID                    DISCIPLINA_ID,
            D.NOME                  DISCIPLINA_NOME,

            M.ID ID_MATERIA,
            M.NOME NOME_MATERIA,
            M.SERIE SERIE_MATERIA

            FROM

            TB_TESTE T

            INNER JOIN
            TB_DISCIPLINA D
            ON(T.DISCIPLINA_ID = D.ID)

            LEFT JOIN
            TB_MATERIA M
            ON(M.ID = T.MATERIA_ID)";
        }

        public Teste SelecionarPorId(int id, bool incluirQuestoes = false, bool incluirAlternativas = false, bool incluirMateria = false)
        {
            throw new NotImplementedException();
        }
    }
}
