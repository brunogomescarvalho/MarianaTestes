using MarianaTestes.Dominio.ModuloMateria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarianaTestes.InfraData.Orm.ModuloMateria
{
    public class MapeadorMateriaOrm : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builderMateria)
        {
            builderMateria.ToTable("TBMateria");
            builderMateria.Property(m => m.Id).IsRequired(true).ValueGeneratedOnAdd();
            builderMateria.Property(m => m.Nome).HasColumnType("varchar(100)").IsRequired();
            builderMateria.Property(m => m.Serie).HasConversion<int>().IsRequired();

            builderMateria.HasOne(m => m.Disciplina)
                .WithMany(d => d.Materias)
                .IsRequired()
                .HasConstraintName("FK_TBMateria_TBDisciplina")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
