using Analisis.Datos.Mapping.Almacen;
using Analisis.Entidades.Info;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapping.Info
{
    public class ClienteMap: IEntityTypeConfiguration<Cliente>
    {
        public void Configure(RelationalEntityTypeBuilder<Cliente> bulder)
        {
            bulder.ToTable("cliente")
               .HasKey(c => c.idcliente);
            bulder.Property(c => c.nombreCliente)
                  .HasMaxLegth(100);
            bulder.Property(c => c.tipoDocumento)
                  .HasMaxLegth(20);
            bulder.Property(c => c.numDocumento)
                  .HasMaxLegth(20);
            bulder.Property(c => c.direccion)
                .HasMaxLegth(70);
            bulder.Property(c => c.telefono)
                .HasMaxLegth(20);
            bulder.Property(c => c.gmail)
                .HasMaxLegth(50);
        }
    }
