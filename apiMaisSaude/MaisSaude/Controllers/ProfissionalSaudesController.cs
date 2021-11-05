using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MaisSaude.Models;

namespace MaisSaude.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalSaudesController : ControllerBase
    {
        private readonly Context _context;

        public ProfissionalSaudesController(Context context)
        {
            _context = context;
        }

        // GET: api/ProfissionalSaudes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfissionalSaude>>> GetProfissionalSaudes()
        {
            return await _context.ProfissionalSaudes.ToListAsync();
        }

        // GET: api/ProfissionalSaudes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfissionalSaude>> GetProfissionalSaude(int id)
        {
            var profissionalSaude = await _context.ProfissionalSaudes.FindAsync(id);

            if (profissionalSaude == null)
            {
                return NotFound();
            }

            return profissionalSaude;
        }

        // PUT: api/ProfissionalSaudes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfissionalSaude(int id, ProfissionalSaude profissionalSaude)
        {
            if (id != profissionalSaude.ID)
            {
                return BadRequest();
            }

            _context.Entry(profissionalSaude).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfissionalSaudeExists(id))
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

        // POST: api/ProfissionalSaudes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProfissionalSaude>> PostProfissionalSaude(ProfissionalSaude profissionalSaude)
        {
            _context.ProfissionalSaudes.Add(profissionalSaude);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfissionalSaude", new { id = profissionalSaude.ID }, profissionalSaude);
        }

        // DELETE: api/ProfissionalSaudes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfissionalSaude(int id)
        {
            var profissionalSaude = await _context.ProfissionalSaudes.FindAsync(id);
            if (profissionalSaude == null)
            {
                return NotFound();
            }

            _context.ProfissionalSaudes.Remove(profissionalSaude);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfissionalSaudeExists(int id)
        {
            return _context.ProfissionalSaudes.Any(e => e.ID == id);
        }
    }
}
