using CourseManagementSystemFinal.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagementSystemFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollCourseController : ControllerBase
    {

        private readonly MyDbContext _context;

        public EnrollCourseController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/EnrollCourse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnrollCourse>>> GetEnrollCourse()
        {
            return await _context.EnrollCourse.ToListAsync();
        }

        // GET: api/EnrollCourse/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnrollCourse>> GetEnrollCourse(long id)
        {
            var enrollCourse = await _context.EnrollCourse.FindAsync(id);

            if (enrollCourse == null)
            {
                return NotFound();
            }

            return enrollCourse;
        }

        // PUT: api/EnrollCourse/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollCourse(long id, EnrollCourse enrollCourse)
        {
            if (id != enrollCourse.EnrollmentId)
            {
                return BadRequest();
            }

            _context.Entry(enrollCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollCourseExists(id))
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

        // POST: api/BookTickets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EnrollCourse>> PostEnrollCourse(EnrollCourse enrollCourse)
        {
            _context.EnrollCourse.Add(enrollCourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnrollCourse", new { id = enrollCourse.EnrollmentId }, enrollCourse);
        }

        // DELETE: api/BookTickets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EnrollCourse>> DeleteEnrollCourse(long id)
        {
            var enrollCourse = await _context.EnrollCourse.FindAsync(id);
            if (enrollCourse == null)
            {
                return NotFound();
            }

            _context.EnrollCourse.Remove(enrollCourse);
            await _context.SaveChangesAsync();

            return enrollCourse;
        }

        private bool EnrollCourseExists(long id)
        {
            return _context.EnrollCourse.Any(e => e.EnrollmentId == id);
        }


        //[HttpDelete("{courseName}")]
        //public async Task<IActionResult> DeleteCourseByName(string courseName)
        //{
        //    var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseName == courseName);

        //    if (course != null)
        //    {
        //        _context.Courses.Remove(course);
        //        await _context.SaveChangesAsync();
        //        return Ok("Course deleted successfully.");
        //    }
        //    else
        //    {
        //        return NotFound("Course not found.");
        //    }
        //}
    }
}
