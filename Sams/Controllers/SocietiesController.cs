using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sams.Models;
using Sams.Models.Contexts;
using Sams.Models.Dtos;

namespace Sams.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class SocietiesController : ControllerBase
    {
        private readonly ILogger<SocietiesController> logger;
        private readonly SamsContext sContext;
        private readonly IMapper mapper;
        public SocietiesController(ILogger<SocietiesController> logger, SamsContext sContext, IMapper mapper)
        {
            this.logger = logger;
            this.sContext = sContext;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<SocietysDto> Get()
        {
            var s = sContext.Societys
                .Include(s => s.StudentSocieties)
                .ThenInclude(ss => ss.Students)
                .ToList();

            return mapper.Map<List<SocietysDto>>(s);
        }

        [HttpPost]
        public SocietysDto Create([FromBody] SocietysDto societyDto)
        {
            var society = mapper.Map<Societys>(societyDto);
            sContext.Societys.Add(society);
            sContext.SaveChanges();
            return mapper.Map<SocietysDto>(society);
        }

        [HttpPost]
        [Route("AddMember")]
        public SocietysDto AddConvenor([FromBody] StudentSocietyDto studentSocietyDto)
        {
            var society = sContext.Societys.Find(studentSocietyDto.SocietyID);
            if(society.StudentSocieties == null)
            {
                society.StudentSocieties = new List<StudentSociety>();
            }
            society.StudentSocieties.Add(mapper.Map<StudentSociety>(studentSocietyDto));
            sContext.SaveChanges();
            return mapper.Map<SocietysDto>(sContext.Societys.Find(studentSocietyDto.SocietyID));
        }

        [HttpDelete]
        public IActionResult Remove([FromHeader] int id)
        {
            throw new NotImplementedException();
        }

    }
}
