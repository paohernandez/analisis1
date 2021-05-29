using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;


namespace Analisis.Datos.Mapping.Usuarios
{
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(RelationalEntityTypeBuilder<Rol> bulder)
        {
            bulder.ToTable("Rol")
               .HasKey(c => c.idrol);
            bulder.Property(c => c.nombre)
            .HasMaxLegth(30);
            bulder.Property(c => c.descripcion)
                  .HasMaxLegth(256);
            bulder.Property(c => c.descripcion)
                  .HasMaxLegth(256);
        }
}
