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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.HasOne(c => c.PerfilUsuario).WithMany(c => c.Usuarios).HasForeignKey(c => c.PerfilUsuarioId);
            builder.HasMany(c => c.UsuariosGuardaChuva).WithOne(c => c.UsuarioIndicacao).HasForeignKey(c => c.UsuarioIndicacaoId);
            builder.Property(c => c.DataDeCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(c => c.DataDeAtualizacao).HasDefaultValue(DateTime.Now);
            builder.HasOne(c => c.CarteiraCashback).WithOne(c => c.Usuario).HasForeignKey<CarteiraCashback>(c => c.UsuarioId);
        }
    }
}
