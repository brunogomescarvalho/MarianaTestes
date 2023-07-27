using MarianaTestes.Dominio.Compartilhado;
using System.Data.SqlClient;

namespace MarianaTestes.InfraData.SqlServer.Compartilhado
{

    public delegate T onObterRegistro<T>(SqlDataReader leitor);
    public abstract class RepositorioBaseSql<TEntidade, TMapeador> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade> where TMapeador : MapeadorBaseSql<TEntidade>, new()
    {
        protected string connectionString;

        protected RepositorioBaseSql(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected abstract string SqlBuscarPorId { get; }
        protected abstract string SqlBuscarTodos { get; }
        protected abstract string SqlCadastrar { get; }
        protected abstract string SqlEditar { get; }
        protected abstract string SqlExcluir { get; }


        public virtual void Cadastrar(TEntidade entidade)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = SqlCadastrar;

            TMapeador mapeador = new TMapeador();

            mapeador.ConverterParaSql(comando, entidade);

            int id = Convert.ToInt32(comando.ExecuteScalar());

            entidade.Id = id;
        }

        public virtual TEntidade BuscarPorId(int id)
        {
            TEntidade entidade = null!;

            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = SqlBuscarPorId;

            comando.Parameters.AddWithValue("ID", id);

            TMapeador mapeador = new TMapeador();

            SqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                entidade = mapeador.ConverterParaObjeto(leitor);
            }

            return entidade;
        }

        public virtual List<TEntidade> BuscarTodos()
        {
            List<TEntidade> registros = new List<TEntidade>();

            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = SqlBuscarTodos;

            SqlDataReader leitor = comando.ExecuteReader();

            TMapeador mapeador = new TMapeador();

            while (leitor.Read())
            {
                TEntidade entidade = mapeador.ConverterParaObjeto(leitor);

                registros.Add(entidade);
            }
            return registros;
        }

        protected List<TEntidade> BuscarTodosPorParametros(List<SqlParameter> parametros, string SqlQuery)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();

            parametros?.ForEach(parametros => { comando.Parameters.Add(parametros); });

            comando.CommandText = SqlQuery;

            SqlDataReader leitor = comando.ExecuteReader();

            TMapeador mapeador = new();
            List<TEntidade> registros = new();

            while (leitor.Read())
            {
                TEntidade entidade = mapeador.ConverterParaObjeto(leitor);
                registros.Add(entidade);
            }
            return registros;
        }

        protected TEntidade BuscarPorParametros(List<SqlParameter> parametros, string SqlQuery)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();

            parametros?.ForEach(parametros => { comando.Parameters.Add(parametros); });

            comando.CommandText = SqlQuery;

            SqlDataReader leitor = comando.ExecuteReader();

            TMapeador mapeador = new();
            TEntidade entidade = null!;

            if (leitor.Read())
            {
                 entidade = mapeador.ConverterParaObjeto(leitor);              
            }
            return entidade;
        }



        public virtual void Editar(TEntidade entidade)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = SqlEditar;

            comando.Parameters.AddWithValue("ID", entidade.Id);

            TMapeador mapeador = new TMapeador();

            mapeador.ConverterParaSql(comando, entidade);

            comando.ExecuteNonQuery();
        }

        public virtual void Excluir(int id)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = SqlExcluir;

            comando.Parameters.AddWithValue("ID", id);

            comando.ExecuteNonQuery();
        }

        public virtual void Excluir(TEntidade entidade)
        {
            Excluir(entidade.Id);
        }

        protected List<T> SelecionarRegistros<T>(string sqlQuery, List<SqlParameter> Parametros, onObterRegistro<T> obterRegistro)
        {
            using SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            using SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = sqlQuery;

            Parametros?.ForEach(p => comando.Parameters.Add(p));

            SqlDataReader leitor = comando.ExecuteReader();

            var listaRegistros = new List<T>();

            while (leitor.Read())
            {
                T registro = obterRegistro(leitor);

                listaRegistros.Add(registro);
            }

            return listaRegistros;
        }

    }

}
