using MarianaTestes.Dominio.ModuloQuestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarianaTestes.InfraData.Orm.ModuloQuestao
{
    public class MapeadorQuestaoOrm : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builderQuestao)
        {
            builderQuestao.ToTable("TBQuestao");
            builderQuestao.Property(q => q.Id).IsRequired(true).ValueGeneratedOnAdd();
            builderQuestao.Property(q => q.Pergunta).HasColumnType("varchar(500)").IsRequired();
            builderQuestao.Property(q => q.Utilizada).IsRequired();

            builderQuestao.HasOne(q => q.Materia)
                .WithMany(m => m.Questoes)
                .IsRequired()
                .HasConstraintName("FK_TBQuestao_TBMateria")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
