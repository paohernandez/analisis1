using Analisis.Datos.Mapping.Almacen;
using Analisis.Datos.Mapping.Usuarios;
using Analisis.Datos.Mapping.Ventas;
using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;


namespace Analisis.Datos
{
    public class DbContextAnalisis : DbContext
    {
        public class DbSet<Categoria> Categoria { get; set; }

public DbContextAnalisis (DbContextOptions<DbContextAnalisis> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticuloMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
             modelBuilder.ApplyConfiguration(new VentaMap());
            modelBuilder.ApplyConfiguration(new IngresoMap());
            modelBuilder.ApplyConfiguration(new PersonaMap());





    }
