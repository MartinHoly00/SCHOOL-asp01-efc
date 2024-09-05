using asp01_efc.Data;
using asp01_efc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp01_efc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrogsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;//misto kam se pripoji trida

        public FrogsController(ApplicationDbContext context)//nasel si tridu 
        {
            _context = context;
        }

        [HttpGet("all")]
        public IActionResult GetFrogs()
        {
            var students = _context.Students;
            return Ok(students);
        }


        [HttpGet("tonda")]
        public IActionResult GetTonda()
        {
            var studentsTonda = _context.Students
                .Where(x => x.FirstName == "Tonda")
                .ToList();
            return Ok(studentsTonda);
        }


        [HttpGet("{id}")]
        public IActionResult GetFrog(int id)
        {
            var student = _context.Students.Find(id);
            if(student == null)
            {
                return NotFound("Id: " + id + " was not found");
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateFrog([FromBody] Student student)
        {
            if (student.ShoeSize > 50 || student.ShoeSize < 0) return BadRequest("Incorect Shoe Size");
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetFrog), new { id = student.StudentId }, student);
        }

    }
}
