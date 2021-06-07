using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
    public class Persona
    {
        public int idpersona { get; set; }
        public int tipoPersona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "el nombre debe tener al menos 12 caracteres")]
        public string nombre { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccionPersona { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "el numero de telefono debe contenes por lo menos 20 dígitos")]
        public string telefonoPersona { get; set; }
        public string gmailPersona { get; set; }

        public Ventas.Ingreso Ingreso
        {
            get => default;
            set
            {
            }
        }

        public Rol Rol
        {
            get => default;
            set
            {
            }
        }

        public Info.Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public Rol Rol1
        {
            get => default;
            set
            {
            }
        }

        public Usuario Usuario
        {
            get => default;
            set
            {
            }
        }

        public Info.Cliente Cliente1
        {
            get => default;
            set
            {
            }
        }

        public Almacen.Articulo Articulo
        {
            get => default;
            set
            {
            }
        }

        public Ventas.Ingreso Ingreso1
        {
            get => default;
            set
            {
            }
        }

        public Ventas.Venta Venta
        {
            get => default;
            set
            {
            }
        }

        public Rol Rol2
        {
            get => default;
            set
            {
            }
        }

        public Usuario Usuario1
        {
            get => default;
            set
            {
            }
        }

        public Info.Cliente Cliente2
        {
            get => default;
            set
            {
            }
        }

        public Ventas.Ingreso Ingreso2
        {
            get => default;
            set
            {
            }
        }

        public Ventas.Venta Venta1
        {
            get => default;
            set
            {
            }
        }
    }
}
