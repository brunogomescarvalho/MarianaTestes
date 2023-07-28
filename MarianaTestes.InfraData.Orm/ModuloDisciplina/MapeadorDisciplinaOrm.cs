using MarianaTestes.Dominio.ModuloDisciplina;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarianaTestes.InfraData.Orm.ModuloDisciplina
{
    public class MapeadorDisciplinaOrm : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builderDisciplina)
        {
            builderDisciplina.ToTable("TBDisciplina");
            builderDisciplina.Property(d => d.Id).IsRequired().ValueGeneratedOnAdd();
            builderDisciplina.Property(d => d.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
