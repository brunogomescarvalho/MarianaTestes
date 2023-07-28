using MarianaTestes.Dominio.ModuloQuestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarianaTestes.InfraData.Orm.ModuloQuestao
{
    internal class MapeadorAlternativaOrm : IEntityTypeConfiguration<Alternativa>
    {
        public void Configure(EntityTypeBuilder<Alternativa> builderAlternativa)
        {
            builderAlternativa.ToTable("TBAlternativa");
            builderAlternativa.Property(a => a.Id).IsRequired(true).ValueGeneratedOnAdd();
            builderAlternativa.Property(a => a.Texto).HasColumnType("varchar(100)").IsRequired();
            builderAlternativa.Property(a => a.EhCorreta).IsRequired();

            builderAlternativa.HasOne(a => a.Questao)
                .WithMany(q => q.Alternativas)
                .IsRequired()
                .HasConstraintName("FK_TBAlternativa_TBQuestao")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
