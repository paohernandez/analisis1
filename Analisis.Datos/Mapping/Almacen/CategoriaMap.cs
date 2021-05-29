using Microsoft.EntityFrameworkCore;
using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Analisis.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure (RelationalEntityTypeBuilder<Categoria> bulder)
        {
            bulder.ToTable("categoria")
                .HasKey(c => c.idcategoria);
            bulder.Property(c => c.tipoComprobante)
            .HasMaxLegth(10); 
            bulder.Property(c => c.serieComprobante)
                  .HasMaxLegth(7);
            bulder.Property(c => c.numComprobante)
            .HasMaxLegth(10);
            bulder.Property(c => c.fecha)
                  .HasMaxLegth(256);
            bulder.Property(c => c.impuesto)
                .HasMaxLegth(11,2);
            bulder.Property(c => c.total)
                .HasMaxLegth(11,2);
            {
            }
        }
    }
}

