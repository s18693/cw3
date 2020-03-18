using System;
using Microsoft.AspNetCore.Mvc;
using cw3.Models;
using cw3.DAL;

namespace cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());

        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudetn(int id)
        {
            
            return Ok("Aktualizacja dokonczona");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {

            return Ok("Usuwanie ukonczone");
        }

        /*
         [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Adam, Jan, Kuba sortowanie={orderBy}";

        } 
         
        [HttpGet]
        //[HttpGet("getStudent")]
        public string GetStudents()
        {
            return "Jan Kowalski";
        }
        
        [HttpPost]
        public string PostStudents([FromBody]Student student)
        {
            return "Jan Kowalski";
        }
          
          
        [HttpGet("{id}")]
        public IActionResult GetStudents2([FromRoute] int id)
        {
            if (id == 1)
                return Ok("Jan Kowalski");
            if (id == 2)
                return Ok("Adam Nowak");
            return NotFound("Student not found");

        }

        [HttpGet("{id}")]
        public string GetStudents2([FromRoute] int id)
        {
            if (id == 1)
                return "Jan Kowalski ";
            if (id == 2)
                return "Adam Nowak";
            return "Student not found";

        }

        [HttpPost]
        public string PostStudents([FromQuery], [FromBody]Student student)
        {
            return "Jan Kowalski";
        }
        */
    }
}