using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class CineOfertaConfig : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            builder.Property(prop => prop.PorcentajeDescuento)
                .HasPrecision(5, 2);

            builder.Property(prop => prop.FechaInicio)
                .HasColumnType("date");

            builder.Property(prop => prop.FechaFin)
                .HasColumnType("date");
        }
    }
}
