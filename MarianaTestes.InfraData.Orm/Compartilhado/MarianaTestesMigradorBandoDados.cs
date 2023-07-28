using Microsoft.EntityFrameworkCore;

namespace MarianaTestes.InfraData.Orm.Compartilhado
{
    public static class MarianaTestesMigradorBandoDados
    {
        public static bool AtualizarBancoDados(DbContext db)
        {
            var qtdMigracoesPendentes = db.Database.GetPendingMigrations().Count();

            if (qtdMigracoesPendentes == 0)
                return false;

            db.Database.Migrate();

            return true;
        }
    }
}
