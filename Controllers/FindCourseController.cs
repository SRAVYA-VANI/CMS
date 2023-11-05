//using CourseManagementSystemFinal.Models;

//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CourseManagementSystemFinal.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FindCourseController : ControllerBase
//    {

//        private readonly MyDbContext _context;

//        public FindCourseController(MyDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/FindTickets
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<FindCourse>>> GetFindCourse()
//        {
//            return await _context.FindCourse.ToListAsync();
//        }

//        [HttpGet("{CourseName}/{Author}")]
//        public async Task<ActionResult<FindCourse>> GetFindCourse(string CourseName, string Author)
//        {
//            var findCourse = await _context.FindCourse.FirstOrDefaultAsync(record => record.CourseName == CourseName && record.Author == Author);

//            if (findCourse == null)
//            {
//                return NotFound();
//            }

//            return findCourse;
//        }

//        // GET: api/FindTickets/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<FindCourse>> GetFindCourse(int id)
//        {
//            var findCourse = await _context.FindCourse.FindAsync(id);

//            if (findCourse == null)
//            {
//                return NotFound();
//            }

//            return findCourse;
//        }

//        // PUT: api/FindTickets/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutFindCourse(int id, FindCourse findCourse)
//        {
//            if (id != findCourse.CourseId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(findCourse).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!FindCourseExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/FindTickets
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<FindCourse>> PostFindCourse(FindCourse findCourse)
//        {
//            _context.FindCourse.Add(findCourse);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetFindCourse", new { id = findCourse.CourseId }, findCourse);
//        }

//        // DELETE: api/FindTickets/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<FindCourse>> DeleteFindCourse(int id)
//        {
//            var findCourse = await _context.FindCourse.FindAsync(id);
//            if (findCourse == null)
//            {
//                return NotFound();
//            }

//            _context.FindCourse.Remove(findCourse);
//            await _context.SaveChangesAsync();

//            return findCourse;
//        }

//        private bool FindCourseExists(int id)
//        {
//            return _context.FindCourse.Any(e => e.CourseId == id);
//        }



//        [HttpDelete("DeleteCourseByName")]
//        public async Task<IActionResult> DeleteCourseByName(string courseName)
//        {
//            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseName == courseName);

//            if (course != null)
//            {
//                _context.Courses.Remove(course);
//                await _context.SaveChangesAsync();
//                return Ok("Course deleted successfully.");
//            }
//            else
//            {
//                return NotFound("Course not found.");
//            }
//        }


//    }
//}
