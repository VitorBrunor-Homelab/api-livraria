using API_Livraria.Data;
using API_Livraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly LivrariaDbContext _context;
        public AutoresController(LivrariaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {
            return await _context.Autores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Autor>> GetAutor(int id)
        {
            var autor = await _context.Autores
                .Include(a => a.Livros)
                .FirstOrDefaultAsync(a => a.ID == id);
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }
    }
}
