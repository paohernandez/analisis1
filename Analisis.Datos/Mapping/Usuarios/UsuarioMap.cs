using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Usuarios;


namespace Analisis.Datos.Mapping.Usuarios
{
    public class UsuarioMap
    {
        public void Configure(RelationalEntityTypeBuilder<Usuario> bulder)
        {
            bulder.ToTable("usuario")
                .HasKey(c => c.idusuario);
            bulder.Property(c => c.nombre)
            .HasMaxLegth(100);
            bulder.Property(c => c.tipoDocumento)
                  .HasMaxLegth(20);
            bulder.Property(c => c.numDocumento)
                  .HasMaxLegth(20);
            bulder.Property(c => c.direccion)
                  .HasMaxLegth(20);
            bulder.Property(c => c.telefono)
                  .HasMaxLegth(20);
            bulder.Property(c => c.gmail)
                  .HasMaxLegth(50);
            bulder.Property(c => c.passwordHash)
                  .HasMaxLegth(64);
            bulder.Property(c => c.passwordSalt)
                  .HasMaxLegth(64);
            bulder.Property(c => c.condicion)
                  .HasMaxLegth(256);
        }
}
