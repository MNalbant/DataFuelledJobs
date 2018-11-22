using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyUsersController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public SurveyUsersController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/SurveyUsers
        [HttpGet]
        public IEnumerable<SurveyUser> GetSurveyUser()
        {
            return _context.SurveyUser;
        }

        // GET: api/SurveyUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSurveyUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var surveyUser = await _context.SurveyUser.FindAsync(id);

            if (surveyUser == null)
            {
                return NotFound();
            }

            return Ok(surveyUser);
        }

        // PUT: api/SurveyUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyUser([FromRoute] int id, [FromBody] SurveyUser surveyUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != surveyUser.SurveyId)
            {
                return BadRequest();
            }

            _context.Entry(surveyUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyUserExists(id))
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

        // POST: api/SurveyUsers
        [HttpPost]
        public async Task<IActionResult> PostSurveyUser([FromBody] SurveyUser surveyUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SurveyUser.Add(surveyUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SurveyUserExists(surveyUser.SurveyId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSurveyUser", new { id = surveyUser.SurveyId }, surveyUser);
        }

        // DELETE: api/SurveyUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurveyUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var surveyUser = await _context.SurveyUser.FindAsync(id);
            if (surveyUser == null)
            {
                return NotFound();
            }

            _context.SurveyUser.Remove(surveyUser);
            await _context.SaveChangesAsync();

            return Ok(surveyUser);
        }

        private bool SurveyUserExists(int id)
        {
            return _context.SurveyUser.Any(e => e.SurveyId == id);
        }
    }
}