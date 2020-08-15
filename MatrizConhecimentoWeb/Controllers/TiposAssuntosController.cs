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
    public class TiposAssuntosController : ControllerBase
    {
        private readonly MATRIZDBContext _context;

        public TiposAssuntosController(MATRIZDBContext context)
        {
            _context = context;
        }

        // GET: api/TiposAssuntos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposAssunto>>> GetTiposAssunto()
        {
            return await _context.TiposAssunto.ToListAsync();
        }

        // GET: api/TiposAssuntos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposAssunto>> GetTiposAssunto(int id)
        {
            var tiposAssunto = await _context.TiposAssunto.FindAsync(id);

            if (tiposAssunto == null)
            {
                return NotFound();
            }

            return tiposAssunto;
        }

        // PUT: api/TiposAssuntos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposAssunto(int id, TiposAssunto tiposAssunto)
        {
            if (id != tiposAssunto.idTipoAssunto)
            {
                return BadRequest();
            }

            _context.Entry(tiposAssunto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposAssuntoExists(id))
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

        // POST: api/TiposAssuntos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TiposAssunto>> PostTiposAssunto(TiposAssunto tiposAssunto)
        {
            _context.TiposAssunto.Add(tiposAssunto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposAssunto", new { id = tiposAssunto.idTipoAssunto }, tiposAssunto);
        }

        // DELETE: api/TiposAssuntos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TiposAssunto>> DeleteTiposAssunto(int id)
        {
            var tiposAssunto = await _context.TiposAssunto.FindAsync(id);
            if (tiposAssunto == null)
            {
                return NotFound();
            }

            _context.TiposAssunto.Remove(tiposAssunto);
            await _context.SaveChangesAsync();

            return tiposAssunto;
        }

        private bool TiposAssuntoExists(int id)
        {
            return _context.TiposAssunto.Any(e => e.idTipoAssunto == id);
        }
    }
}
