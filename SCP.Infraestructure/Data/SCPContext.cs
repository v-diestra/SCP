using Microsoft.EntityFrameworkCore;
using SCP.Core.ModelEntity;
using SCP.Infraestructure.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCP.Infraestructure.Data
{
    public class SCPContext : DbContext
    {
        public SCPContext(DbContextOptions<SCPContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
        public DbSet<Usuario> Usuario { get; set; }

    }

}
