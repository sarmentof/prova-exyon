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
    public class CriteriosController : ControllerBase
    {
        private readonly MATRIZDBContext _context;

        public CriteriosController(MATRIZDBContext context)
        {
            _context = context;
        }

        // GET: api/Criterios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Criterios>>> GetCriterios()
        {
            return await _context.Criterios.ToListAsync();
        }

        // GET: api/Criterios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Criterios>> GetCriterios(int id)
        {
            var criterios = await _context.Criterios.FindAsync(id);

            if (criterios == null)
            {
                return NotFound();
            }

            return criterios;
        }

        // PUT: api/Criterios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCriterios(int id, Criterios criterios)
        {
            if (id != criterios.idCriterio)
            {
                return BadRequest();
            }

            _context.Entry(criterios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriteriosExists(id))
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

        // POST: api/Criterios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Criterios>> PostCriterios(Criterios criterios)
        {
            _context.Criterios.Add(criterios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCriterios", new { id = criterios.idCriterio }, criterios);
        }

        // DELETE: api/Criterios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Criterios>> DeleteCriterios(int id)
        {
            var criterios = await _context.Criterios.FindAsync(id);
            if (criterios == null)
            {
                return NotFound();
            }

            _context.Criterios.Remove(criterios);
            await _context.SaveChangesAsync();

            return criterios;
        }

        private bool CriteriosExists(int id)
        {
            return _context.Criterios.Any(e => e.idCriterio == id);
        }
    }
}
