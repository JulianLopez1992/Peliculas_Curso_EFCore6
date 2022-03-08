using EFCorePeliculas.Entidades;
using EFCorePeliculas.Entidades.Configuraciones;
using EFCorePeliculas.Entidades.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CineOfertas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<SalaCine> SalasCine { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date"); //Creo una convencion por defecto.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new GeneroConfig()); //Priemra manera: Se hace por cada una de las clases.

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Segunda manera: Aplica la configuracion para todas las clases que heredan de IEntityTypeConfiguration del ensamblado (Proyecto) que se esta ejecutando.

            SeedingModuloConsulta.Seed(modelBuilder);
            //modelBuilder.Entity<Genero>().ToTable("NombreTabla", "NombreSchema");

            //modelBuilder.Entity<Actor>().Property(prop => prop.Nombre)
            //    .IsRequired()
            //    .HasMaxLength(150);

            //modelBuilder.Entity<Actor>().Property(prop => prop.FechaNacimiento)
            //    .HasColumnType("date");

            //modelBuilder.Entity<Cine>().Property(prop => prop.Nombre)
            //    .HasMaxLength(150);

            //modelBuilder.Entity<Cine>().Property(prop => prop.Precio)
            //    .HasPrecision(9, 2);

            //modelBuilder.Entity<Pelicula>().Property(prop => prop.Titulo)
            //    .HasMaxLength(150)
            //    .IsRequired();

            //modelBuilder.Entity<Pelicula>().Property(prop => prop.FechaEstreno)
            //    .HasColumnType("date");

            //modelBuilder.Entity<Pelicula>().Property(prop => prop.PosterURL)
            //    .HasMaxLength(500)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CineOferta>().Property(prop => prop.PorcentajeDescuento)
            //    .HasPrecision(5, 2);

            //modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaInicio)
            //    .HasColumnType("date");

            //modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaFin)
            //    .HasColumnType("date");

            //modelBuilder.Entity<SalaCine>().Property(prop => prop.Precio)
            //    .HasPrecision(9, 2);

            //modelBuilder.Entity<SalaCine>().Property(prop => prop.TipoSala)
            //    .HasDefaultValue(TipoSalaCine.DosDimensiones);

            //modelBuilder.Entity<PeliculaActor>().HasKey(key => new { key.PeliculaId, key.ActorId }); //LLave compuesta.

            //modelBuilder.Entity<PeliculaActor>().Property(prop => prop.Personaje)
            //                .HasMaxLength(150);


        }


    }
}
