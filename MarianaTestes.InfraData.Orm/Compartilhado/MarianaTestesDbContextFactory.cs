using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MarianaTestes.InfraData.Orm.Compartilhado
{
    internal class MarianaTestesDbContextFactory : IDesignTimeDbContextFactory<MarianaTestesDbContext>
    {
        public MarianaTestesDbContext CreateDbContext(string[] args)
        {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var builder = new DbContextOptionsBuilder<MarianaTestesDbContext>();

            builder.UseSqlServer(connectionString);

            return new MarianaTestesDbContext(builder.Options);
        }
    }
}
