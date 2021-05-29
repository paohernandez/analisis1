using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<Venta>
    {
        public void Configure(RelationalEntityTypeBuilder<Venta> bulder)
        {
            bulder.ToTable("venta")
                .HasKey(c => c.idventa);
            bulder.Property(c => c.nombre)
            .HasMaxLegth(50);
            bulder.Property(c => c.descripcion)
                  .HasMaxLegth(256);
        }
}
