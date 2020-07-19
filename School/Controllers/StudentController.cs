using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.SchoolDao;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _schoolContext;

        public StudentController(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            List<Student> studentList = _schoolContext.Student.ToList();
            return studentList;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}