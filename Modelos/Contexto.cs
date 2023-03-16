using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelos
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EducacionCorporal"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            modelBuilder.Entity<Sexo>()
            .HasMany(e => e.Pacientes)
            .WithOne(e => e.Sexo)
            .HasForeignKey(e => e.IdSexo);
        }
    }
}
