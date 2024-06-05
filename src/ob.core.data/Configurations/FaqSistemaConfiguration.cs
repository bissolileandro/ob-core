using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.data.Configurations
{
    public class FaqSistemaConfiguration : IEntityTypeConfiguration<FaqSistema>
    {
        public void Configure(EntityTypeBuilder<FaqSistema> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(c => c.DataDeCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(c => c.DataDeAtualizacao).HasDefaultValue(DateTime.Now);
            builder.HasOne(c => c.Sistema).WithMany(c => c.FaqSistemas).HasForeignKey(c => c.SistemaId);
        }
    }
}
