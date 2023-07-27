using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.InfraData.SqlServer.Compartilhado;
using MarianaTestes.InfraData.SqlServer.ModuloMateria;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.ModuloDisciplina
{
    public class RepositorioDisciplinaSql : RepositorioBaseSql<Disciplina, MapeadorDisciplinaSql>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaSql(string connectionString) : base(connectionString)
        {
        }

        protected override string SqlBuscarPorId => ObterQueryBuscarPorId();

        protected override string SqlBuscarTodos => ObterQueryBuscarTodos();

        protected override string SqlCadastrar => ObterQueryCadastrar();

        protected override string SqlEditar => ObterQueryEditar();

        protected override string SqlExcluir => ObterQueryExcluir();



        public override Disciplina BuscarPorId(int id)
        {
            Disciplina disciplina = base.BuscarPorId(id);

            List<Materia> materias = BuscarMaterias(disciplina.Id);

            materias.ForEach(i => disciplina.AdicionarMateria(i));

            return disciplina;

        }


        public List<Disciplina> BuscarTodos(bool buscarMaterias = false)
        {
            List<Disciplina> disciplinas = base.BuscarTodos();

            if (buscarMaterias == true)
            {
                disciplinas.ForEach(i => i.Materias.AddRange(BuscarMaterias(i.Id)));
            }

            return disciplinas;
        }


        public Disciplina BuscarDisciplinaPorNome(string nome)
        {
            List<SqlParameter>parametros = new List<SqlParameter>() { new SqlParameter("NOME_DISCIPLINA", nome)};

            return BuscarPorParametros(parametros, ObterQueryBuscarPorNome());
        }

        private List<Materia> BuscarMaterias(int idDisciplina)
        {
            MapeadorMateriaSql mapeadorMateria = new MapeadorMateriaSql();

            List<SqlParameter> parametros = new List<SqlParameter> { new SqlParameter("ID_DISCIPLINA", idDisciplina) };

            return SelecionarRegistros(ObterQueryBuscarMateriasDisciplina(), parametros, mapeadorMateria.ConverterParaObjeto);
        }

       
        private string ObterQueryBuscarPorNome()
        {
            return ObterQueryBuscarTodos() + " WHERE NOME = @NOME_DISCIPLINA";
        }


        private string ObterQueryBuscarPorId()
        {
            return @"SELECT 
             [ID] AS DISCIPLINA_ID
            ,[NOME] AS DISCIPLINA_NOME
             FROM [TB_DISCIPLINA] WHERE [ID] = @ID";
        }

        private string ObterQueryCadastrar()
        {
            return @"INSERT INTO 
            [TB_DISCIPLINA]
            ([NOME]) VALUES (@NOME)

            SELECT SCOPE_IDENTITY()";
        }

        private string ObterQueryEditar()
        {
            return @"UPDATE 
            [TB_DISCIPLINA] SET 
            [NOME] = @NOME 
            WHERE [ID] = @ID";
        }

        private string ObterQueryExcluir()
        {
            return @"DELETE 
            FROM [TB_DISCIPLINA]
            WHERE [ID] = @ID";
        }

        private string ObterQueryBuscarTodos()
        {
            return @"SELECT 
             [ID] AS DISCIPLINA_ID
            ,[NOME] AS DISCIPLINA_NOME

            FROM [TB_DISCIPLINA]";
        }

        private string ObterQueryBuscarMateriasDisciplina()
        {
            return @"SELECT                  
             M.ID              ID_MATERIA
            ,M.NOME		       NOME_MATERIA
            ,M.SERIE	       SERIE_MATERIA
            ,D.ID              DISCIPLINA_ID
            ,D.NOME            DISCIPLINA_NOME
            FROM TB_MATERIA M

            INNER JOIN 
            [TB_DISCIPLINA]D
            ON (D.ID = M.DISCIPLINA_ID)

            WHERE D.ID = @ID_DISCIPLINA";
        }

    }
}
