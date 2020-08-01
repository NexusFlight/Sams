using Sams.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models.Dtos
{
    public class ConvenorsDto
    {
        public Guid ConvenorID { get; set; }
        public string ConvenorType { get; set; }
        public bool ConvenorTrainingTaken { get; set; }
        public string ConvenorPVGStatus { get; set; }

        public List<SocietysDto> Societys { get; set; }
        public List<StudentsDto> Students { get; set; }
    }
}
