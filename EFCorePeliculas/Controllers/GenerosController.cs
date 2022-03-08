using EFCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GenerosController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Genero>> Get() 
        {
            var miVar = await _context.Generos.ToListAsync();
            return await _context.Generos.ToListAsync();
        }
    }
}
