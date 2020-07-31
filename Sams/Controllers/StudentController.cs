
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Sams.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> logger;
        private readonly StudentContext sContext;
        public StudentController(ILogger<StudentController> logger, StudentContext sContext)
        {
            this.logger = logger;
            this.sContext = sContext;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return sContext.Students
                .Include(student => student.ContactPreferences)
                .Include(student => student.ContactDetails)
                .ThenInclude(contactDetails => contactDetails.Address);
        }

        [HttpPost]
        public Student Create([FromBody]Student student)
        {
            Console.WriteLine(student.StudentName);
            var returned = sContext.Add(student);
            sContext.SaveChanges();
            return returned.Entity;
            
        }

        [HttpDelete]
        public IActionResult Remove([FromHeader]int id)
        {
            var student = sContext.Students.Remove(sContext.Students.Find(id));
            if(student.Entity != null)
            {
                sContext.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
