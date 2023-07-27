using MarianaTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace MarianaTestes.InfraData.SqlServer.Compartilhado
{
    public abstract class MapeadorBaseSql<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        public abstract void ConverterParaSql(SqlCommand comando, TEntidade entidade);

        public abstract TEntidade ConverterParaObjeto(SqlDataReader leitor);
    }
}
