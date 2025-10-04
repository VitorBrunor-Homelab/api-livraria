using API_Livraria.Data;
using API_Livraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivrariaDbContext _context;
        public LivrosController(LivrariaDbContext context) { _context = context; }

        [HttpGet("com-autores")]
        public async Task<ActionResult<IEnumerable<LivroComAutor>>> GetLivrosComAutores()
        {
            return await _context.LivrosComAutores.ToListAsync();
        }
    }
}
