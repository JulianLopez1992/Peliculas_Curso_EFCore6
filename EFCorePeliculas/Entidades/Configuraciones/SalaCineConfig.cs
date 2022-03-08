using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class SalaCineConfig : IEntityTypeConfiguration<SalaCine>
    {
        public void Configure(EntityTypeBuilder<SalaCine> builder)
        {

            builder.Property(prop => prop.Precio)
                 .HasPrecision(9, 2);

            builder.Property(prop => prop.TipoSala)
                .HasDefaultValue(TipoSalaCine.DosDimensiones);
        }
    }
}
