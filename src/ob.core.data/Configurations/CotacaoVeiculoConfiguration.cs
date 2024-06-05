using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ob.core.domain.Entities;

namespace ob.core.data.Configurations
{
    public class CotacaoVeiculoConfiguration : IEntityTypeConfiguration<CotacaoVeiculo>
    {
        public void Configure(EntityTypeBuilder<CotacaoVeiculo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(c => c.DataDeCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(c => c.DataDeAtualizacao).HasDefaultValue(DateTime.Now);
        }
    }
}
