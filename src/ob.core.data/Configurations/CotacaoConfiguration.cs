using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ob.core.domain.Entities;

namespace ob.core.data.Configurations
{
    public class CotacaoConfiguration : IEntityTypeConfiguration<Cotacao>
    {
        public void Configure(EntityTypeBuilder<Cotacao> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(c => c.DataDeCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(c => c.DataDeAtualizacao).HasDefaultValue(DateTime.Now);
            builder.HasOne(c => c.CotacaoVeiculo).WithOne(c => c.Cotacao).HasForeignKey<CotacaoVeiculo>(d => d.CotacaoId);
            builder.HasOne(c => c.CotacaoDetalhes).WithOne(c => c.Cotacao).HasForeignKey<CotacaoDetalhes>(d => d.CotacaoId);
        }
    }
}
