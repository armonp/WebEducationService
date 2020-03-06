using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Data;
using WebEducationService.Models;

namespace WebEducationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassRelsController : ControllerBase
    {
        private readonly EdDbContext _context;

        public StudentClassRelsController(EdDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentClassRels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentClassRel>>> GetStudentClassRel()
        {
            return await _context.StudentClassRel.ToListAsync();
        }

        // GET: api/StudentClassRels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentClassRel>> GetStudentClassRel(int id)
        {
            var studentClassRel = await _context.StudentClassRel.FindAsync(id);

            if (studentClassRel == null)
            {
                return NotFound();
            }

            return studentClassRel;
        }

        // PUT: api/StudentClassRels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentClassRel(int id, StudentClassRel studentClassRel)
        {
            if (id != studentClassRel.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentClassRel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentClassRelExists(id))
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

        // POST: api/StudentClassRels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StudentClassRel>> PostStudentClassRel(StudentClassRel studentClassRel)
        {
            _context.StudentClassRel.Add(studentClassRel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentClassRel", new { id = studentClassRel.Id }, studentClassRel);
        }

        // DELETE: api/StudentClassRels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentClassRel>> DeleteStudentClassRel(int id)
        {
            var studentClassRel = await _context.StudentClassRel.FindAsync(id);
            if (studentClassRel == null)
            {
                return NotFound();
            }

            _context.StudentClassRel.Remove(studentClassRel);
            await _context.SaveChangesAsync();

            return studentClassRel;
        }

        private bool StudentClassRelExists(int id)
        {
            return _context.StudentClassRel.Any(e => e.Id == id);
        }
    }
}
