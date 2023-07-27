using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloQuestao
{
    public class RepositorioQuestaoSql : RepositorioBaseSql<Questao, MapeadorQuestaoSql>, IRepositorioQuestao
    {
        public RepositorioQuestaoSql(string connectionString) : base(connectionString)
        {
        }

        protected override string SqlBuscarPorId => ObterQueryBuscarPorId();

        protected override string SqlBuscarTodos => ObterQueryBuscarTodos();

        protected override string SqlCadastrar => ObterQueryCadastrar();

        protected override string SqlEditar => ObterQueryEditar();

        protected override string SqlExcluir => ObterQueryExcluir();



        public override void Cadastrar(Questao entidade)
        {
            base.Cadastrar(entidade);

            foreach (var item in entidade.Alternativas)
            {
                item.Questao = entidade;

                CadastrarAlternativas(item);
            }
        }

        public List<Questao> BuscarTodos(bool carregarAlternativas = false)
        {
            var questoes = base.BuscarTodos();

            if(carregarAlternativas)
            {
                questoes.ForEach(x => x.Alternativas.AddRange(BuscarAlternativas(x.Id)));
            }

            return questoes;
        }

        public override Questao BuscarPorId(int id)
        {
            Questao questao = base.BuscarPorId(id);
         
            questao?.Alternativas.AddRange(BuscarAlternativas(questao.Id));

            return questao;

        }

        public override void Editar(Questao questao)
        {
            base.Editar(questao);

            ExcluirALternativas(questao.Id);

            questao.Alternativas.ForEach(i => { i.Questao = questao; CadastrarAlternativas(i); }) ;
        }

        public override void Excluir(int id)
        {
            if (!QuestaoJaUtilizada(id))
            {
                ExcluirALternativas(id);

                base.Excluir(id);
            }
            else           
                throw new Exception();
            
        }

        public List<Questao> BuscarQuestoesProvaRecuperacao(int idDisciplina, SerieMateriaEnum serie)
        {
            List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("DISCIPLINA_ID", idDisciplina), new SqlParameter("MATERIA_SERIE", serie) };
           
            return BuscarTodosPorParametros(parameters, ObterQueryBuscarQuestoesTesteRecuperacao());
        }
       
        public List<Questao> BuscarQuestoesNaoUtilizadas()
        {
            return BuscarTodosPorParametros(null!, ObterQueryQuestoesNaoUtilizadas());
        }

        public List<Questao> BuscarQuestoesUtilizadas()
        {
            return BuscarTodosPorParametros(null!, ObterQueryQuestoesUtilizadas());
        }

        public List<Questao> FiltrarQuestoesPorMateria(Materia materia)
        {
            List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("ID_MATERIA", materia.Id) };

            return BuscarTodosPorParametros(parameters, ObterQueryBuscar_QuestoesPorMateria());
        }




        private List<Alternativa> BuscarAlternativas(int idQuestao)
        {
            List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("ID_QUESTAO", idQuestao) };

            MapeadorAlternativa mapeador = new MapeadorAlternativa();

            return SelecionarRegistros(ObterQueryBuscarAlternativas(), parameters, mapeador.ConverterParaObjeto);
        }

        private void ExcluirALternativas(int id, bool ExcluirPorId = false)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            if (ExcluirPorId == false)
            {
                comando.CommandText = ObterQueryExcluirAlternativas();

                comando.Parameters.AddWithValue("ID_QUESTAO", id);
            }
            else
            {
                comando.CommandText = ObterQueryExcluirAlternativaPorId();

                comando.Parameters.AddWithValue("ID_ALTERNATIVA", id);
            }

            comando.ExecuteNonQuery();
        }

        private void CadastrarAlternativas(Alternativa alternativa)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = ObterQueryInsertAlternativa();

            MapeadorAlternativa mapeadorAlternativa = new MapeadorAlternativa();

            mapeadorAlternativa.ConverterParaSql(comando, alternativa);

            comando.ExecuteNonQuery();
        }

        private bool QuestaoJaUtilizada(int idQuestao)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = ObterQueryVerificarQuestaoUtilizada();

            comando.Parameters.AddWithValue("ID_QUESTAO", idQuestao);

            return (int)comando.ExecuteScalar() > 0;
        }


        private string ObterQueryQuestoesUtilizadas()
        {
            return ObterQueryBuscarTodos() + " INNER JOIN TB_TESTE_TB_QUESTAO TQ ON (Q.ID = TQ.ID_QUESTAO)";
        }


        private string ObterQueryVerificarQuestaoUtilizada()
        {
            return @"SELECT COUNT(ID_TESTE) FROM TB_TESTE_TB_QUESTAO WHERE [ID_QUESTAO] = @ID_QUESTAO";
        }

        private string ObterQueryBuscar_QuestoesPorMateria()
        {
            return ObterQueryBuscarTodos() + " WHERE M.ID = @ID_MATERIA";
        }

        private string ObterQueryBuscarPorId()
        {
            return ObterQueryBuscarTodos() + " WHERE Q.ID = @ID";
        }

        private string ObterQueryExcluir()
        {
            return @"DELETE FROM TB_QUESTAO WHERE ID = @ID";
        }

        private string ObterQueryExcluirAlternativas()
        {
            return @"DELETE 
            FROM TB_ALTERNATIVA
            WHERE QUESTAO_ID = @ID_QUESTAO";
        }

        private string ObterQueryExcluirAlternativaPorId()
        {
            return @"DELETE 
            FROM TB_ALTERNATIVA
            WHERE ID = @ID_ALTERNATIVA";
        }

        private string ObterQueryQuestoesNaoUtilizadas()
        {
            return ObterQueryBuscarTodos() + @"
            WHERE NOT EXISTS
            (SELECT *  
            FROM  TB_TESTE_TB_QUESTAO TQ
            WHERE Q.ID = TQ.ID_QUESTAO)";
        }
        private string ObterQueryEditar()
        {
            return @"UPDATE 
            TB_QUESTAO SET 
            PERGUNTA = @PERGUNTA,
            MATERIA_ID = @MATERIA_ID
            WHERE ID = @ID";
        }

        private string ObterQueryCadastrar()
        {
            return @"INSERT INTO 
            TB_QUESTAO 
            (PERGUNTA
            ,MATERIA_ID)

            VALUES 
            (@PERGUNTA
            ,@MATERIA_ID)

            SELECT SCOPE_IDENTITY()";
        }

        private string ObterQueryInsertAlternativa()
        {
            return @"INSERT INTO 
            [TB_ALTERNATIVA]              
            ([QUESTAO_ID]
            ,[TEXTO]
            ,[CORRETA])  

            VALUES
            (@QUESTAO_ID
            ,@TEXTO
            ,@CORRETA)";
        }

        private string ObterQueryBuscarQuestoesTesteRecuperacao()
        {
            return @"SELECT		 
            Q.ID AS ID_QUESTAO
            ,Q.PERGUNTA

            ,M.ID ID_MATERIA
            ,M.NOME NOME_MATERIA
            ,M.SERIE SERIE_MATERIA          
            ,M.DISCIPLINA_ID

            ,D.NOME DISCIPLINA_NOME

            FROM TB_QUESTAO Q

            INNER JOIN TB_MATERIA M   
            ON (Q.MATERIA_ID = M.ID)
            INNER JOIN TB_DISCIPLINA D 
            ON (D.ID = @DISCIPLINA_ID)

            WHERE M.SERIE = @MATERIA_SERIE 
            AND M.DISCIPLINA_ID = @DISCIPLINA_ID

            AND NOT EXISTS
            (SELECT *  
            FROM  TB_TESTE_TB_QUESTAO TQ
            WHERE Q.ID = TQ.ID_QUESTAO)";
        }

        private string ObterQueryBuscarTodos()
        {
            return @"SELECT		 
            Q.ID AS ID_QUESTAO
            ,Q.PERGUNTA

            ,M.ID ID_MATERIA
            ,M.NOME NOME_MATERIA
            ,M.SERIE SERIE_MATERIA
            ,M.DISCIPLINA_ID

            ,D.NOME DISCIPLINA_NOME

            FROM TB_QUESTAO Q

            INNER JOIN
            TB_MATERIA M
            ON(Q.MATERIA_ID = M.ID)
        
            INNER JOIN
            TB_DISCIPLINA D 
            ON(D.ID = M.DISCIPLINA_ID)";
        }


        private string ObterQueryBuscarAlternativas()
        {
            return @"SELECT
            A.[ID] ALTERNATIVA_ID
            ,A.[TEXTO] ALTERNATIVA_TEXTO
            ,A.[CORRETA] ALTERNATIVA_CORRETA

            ,Q.[ID] ID_QUESTAO
            ,Q.[PERGUNTA]

            ,M.[ID] ID_MATERIA
            ,M.[NOME] NOME_MATERIA
            ,M.[SERIE] SERIE_MATERIA

            ,D.[ID] DISCIPLINA_ID
            ,D.[NOME] DISCIPLINA_NOME

            FROM[TB_ALTERNATIVA]A

            INNER JOIN
            [TB_QUESTAO]Q 
            ON(Q.ID = A.QUESTAO_ID)
                
            INNER JOIN
            [TB_MATERIA]M
            ON(M.ID = Q.MATERIA_ID)

            INNER JOIN
            [TB_DISCIPLINA]D
            ON(D.ID = M.DISCIPLINA_ID)

            WHERE[QUESTAO_ID] = @ID_QUESTAO";
        }

       
    }
}
