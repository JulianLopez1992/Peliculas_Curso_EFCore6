using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {
           builder.HasKey(key => new { key.PeliculaId, key.ActorId }); //LLave compuesta.

            builder.Property(prop => prop.Personaje)
                            .HasMaxLength(150);
        }
    }
}
