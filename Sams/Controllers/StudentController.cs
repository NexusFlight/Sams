
using AutoMapper;
using AutoMapper.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sams.Models;
using Sams.Models.Contexts;
using Sams.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Sams.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> logger;
        private readonly SamsContext sContext;
        private readonly IMapper mapper;
        public StudentController(ILogger<StudentController> logger, SamsContext sContext, IMapper mapper)
        {
            this.logger = logger;
            this.sContext = sContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<StudentsDto> Get()
        {
            var s = sContext.Students
                .Include(s => s.StudentConvenors)
                .ThenInclude(sc => sc.Convenor)
                .ThenInclude(c => c.SocietyConvenors)
                .ThenInclude(sc => sc.Society)
                .Include(s => s.StudentSocieties)
                .ThenInclude(s=> s.Society)
                .Include(s => s.StudentSuggestions)
                .ThenInclude(ss => ss.Suggestion)
                .ToList();

            return mapper.Map<List<StudentsDto>>(s);
        }

        [HttpPost]
        public StudentsDto Create([FromBody] StudentsDto studentDto)
        {
            var student = mapper.Map<Students>(studentDto);
            sContext.Students.Add(student);
            sContext.SaveChanges();
            return mapper.Map<StudentsDto>(student);
        }

        [HttpDelete]
        public IActionResult Remove([FromHeader] int id)
        {
            throw new NotImplementedException();
        }
    }
}
