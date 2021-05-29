using Analisis.Datos.Mapping.Almacen;
using Microsoft.EntityFrameworkCore;


namespace Analisis.Datos
{
    public class DbContextAnalisis : DbContext
    {
        public DbContextAnalisis (DbContextOptions<DbContextAnalisis> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());


        }
