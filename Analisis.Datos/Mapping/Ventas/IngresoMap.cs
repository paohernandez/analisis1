using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;


namespace Analisis.Datos.Mapping.Ventas
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(RelationalEntityTypeBuilder<Ingreso> bulder)
      {
            bulder.ToTable("Ingreso")
                     .HasKey(c => c.idingreso);
            bulder.Property(c => c.tipoComprobante)
            .HasMaxLegth(20);
            bulder.Property(c => c.serieComprobante)
                  .HasMaxLegth(7);
            bulder.Property(c => c.numComprobante)
            .HasMaxLegth(10);
            bulder.Property(c => c.fecha)
                  .HasMaxLegth(256);
            bulder.Property(c => c.impuesto)
                .HasMaxLegth(11, 2);
            bulder.Property(c => c.total)
              .HasMaxLegth(11, 2);
            bulder.Property(c => c.condicion)
              .HasMaxLegth(256);
        }
}
