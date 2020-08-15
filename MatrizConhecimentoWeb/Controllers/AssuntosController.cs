using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatrizConhecimentoWeb.Models;


namespace MatrizConhecimentoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssuntosController : ControllerBase
    {
        private readonly MATRIZDBContext _context;

        public AssuntosController(MATRIZDBContext context)
        {
            _context = context;
        }

        // GET: api/Assuntos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assuntos>>> GetAssuntos()
        {
            return await _context.Assuntos.ToListAsync();
        }

        // GET: api/Assuntos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assuntos>> GetAssuntos(int id)
        {
            var assuntos = await _context.Assuntos.FindAsync(id);

            if (assuntos == null)
            {
                return NotFound();
            }

            return assuntos;
        }

        // PUT: api/Assuntos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssuntos(int id, Assuntos assuntos)
        {
            if (id != assuntos.idAssunto)
            {
                return BadRequest();
            }

            _context.Entry(assuntos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssuntosExists(id))
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

        // POST: api/Assuntos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Assuntos>> PostAssuntos(Assuntos assuntos)
        {
            _context.Assuntos.Add(assuntos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssuntos", new { id = assuntos.idAssunto }, assuntos);
        }

        // DELETE: api/Assuntos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Assuntos>> DeleteAssuntos(int id)
        {
            var assuntos = await _context.Assuntos.FindAsync(id);
            if (assuntos == null)
            {
                return NotFound();
            }

            _context.Assuntos.Remove(assuntos);
            await _context.SaveChangesAsync();

            return assuntos;
        }

        private bool AssuntosExists(int id)
        {
            return _context.Assuntos.Any(e => e.idAssunto == id);
        }
    }
}
