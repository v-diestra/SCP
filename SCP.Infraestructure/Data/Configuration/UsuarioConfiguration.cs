using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCP.Core.ModelEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCP.Infraestructure.Data.Configuration
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(e => e.IdUsuario);
            /*builder.Property(e => e.IdUsuario)
                .HasColumnName("IdUsuario");
            builder.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            */ 
        }
    }
}
