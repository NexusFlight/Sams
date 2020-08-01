using Newtonsoft.Json;
using Sams.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models.Dtos
{
    public class SocietysDto
    {
        public Guid SocietyID { get; set; }
        public string SocietyName { get; set; }
        public string SocietyRunningTimes { get; set; }

        [JsonIgnore]
        public List<ConvenorsDto> Convenors { get; set; }
        [JsonIgnore]
        public List<StudentsDto> Students { get; set; }

    }
}
