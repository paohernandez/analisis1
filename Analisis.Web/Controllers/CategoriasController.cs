using Analisis.Datos;
using Analisis.Entidades.Almacen;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController ]
    public class GetCategorias: ControllerBase
    {
        private readonly DbContextAnalisis_context;
            public GetCategorias(DbContextAnalisis context)
        {
            _context = context;
        }
        [HttpGet]
      public async Task<ActionResult><IEnumerable<Categoria>>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        [HttpGet("{idcategoria}")]
        public async Task<ActionResult<Categorias>>GetCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
        if(categoria == null)
            {
                return NotFound();
            }
            return categoria;
        }
        [HttpGet("{idcategoria}")]
        public async Task<ActionResult>PutCategoria(int id, Categoria categoria )
        {

            if (id != categoria.idcategoria)
            {
                return BadRequest();
            }
            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAnsync();
            }

            catch (DbUpdateConcurrencyExeption)
            {
                if(!CategoriaExists(id))
                {
                    return NotFound();


                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }


