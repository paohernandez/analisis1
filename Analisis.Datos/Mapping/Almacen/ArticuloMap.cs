using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Analisis.Entidades.Almacen;

namespace Analisis.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(RelationalEntityTypeBuilder<Categoria> bulder)
        {
            bulder.ToTable("articulo")
                .HasKey(c => c.idarticulo);
            bulder.Property(c => c.codigo)
            .HasMaxLegth(50);
            bulder.Property(c => c.nombre)
                  .HasMaxLegth(100);
            bulder.Property(c => c.precio)
                 .HasMaxLegth(11,2);
            bulder.Property(c => c.stock)
                 .HasMaxLegth(256);
            bulder.Property(c => c.descripcion)
                 .HasMaxLegth(256);
            bulder.Property(c => c.condicion)
                 .HasMaxLegth(256);
        }
    }
}
}
