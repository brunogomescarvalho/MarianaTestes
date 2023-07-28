using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MarianaTestes.InfraData.Orm.Compartilhado
{
    public class MarianaTestesDbContext : DbContext
    {
        public MarianaTestesDbContext(DbContextOptions options) : base(options)
        {
        }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly assembly = typeof(MarianaTestesDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
