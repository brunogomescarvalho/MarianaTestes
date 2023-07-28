using MarianaTestes.Dominio.ModuloTeste;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarianaTestes.InfraData.Orm.ModuloTeste
{
    public class MapeadorTesteOrm : IEntityTypeConfiguration<Teste>
    {
        public void Configure(EntityTypeBuilder<Teste> builderTeste)
        {
            builderTeste.ToTable("TBTeste");
            builderTeste.Property(t => t.Id).IsRequired(true).ValueGeneratedOnAdd();
            builderTeste.Property(t => t.Titulo).HasColumnType("varchar(250)").IsRequired();
            builderTeste.Property(t => t.Recuperacao).IsRequired();
            builderTeste.Property(t => t.DataTeste).IsRequired();
            builderTeste.Property(t => t.QtdQuestoes).IsRequired();

            builderTeste.HasOne(t => t.Disciplina)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBTeste_TBDisciplina")
            .OnDelete(DeleteBehavior.NoAction);

            builderTeste.HasOne(t => t.Materia)
                .WithMany()
                .IsRequired(false)
                .HasConstraintName("FK_TBTeste_TBMateria")
                .OnDelete(DeleteBehavior.NoAction);

            builderTeste.HasMany(t => t.Questoes)
                .WithMany()
                .UsingEntity(x => x.ToTable("TBTeste_TBQuestao"));
        }
    }
}
