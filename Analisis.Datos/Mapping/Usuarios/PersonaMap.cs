using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapping.Usuarios
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(RelationalEntityTypeBuilder<Persona> bulder)
        {
            bulder.ToTable("persona")
               .HasKey(c => c.idpersona);
            bulder.Property(c => c.nombrePersona)
                  .HasMaxLegth(100);
            bulder.Property(c => c.tipoCliente)
                  .HasMaxLegth(20);
            bulder.Property(c => c.direccionCliente)
                .HasMaxLegth(70);
            bulder.Property(c => c.gmailCliente)
                .HasMaxLegth(50);
        }
}
    }
