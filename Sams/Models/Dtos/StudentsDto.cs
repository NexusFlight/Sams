using Sams.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models.Dtos
{
    public class StudentsDto
    {
        public Guid StudentGuid { get; set; }
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        public string StudentCourseCode { get; set; }
        public string StudentCourseTitle { get; set; }
        public bool StudentIsClassRep { get; set; }
        public bool ContactPreferenceByPhone { get; set; }
        public bool ContactPreferenceByEmail { get; set; }
        public bool ContactPreferenceByLetter { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string StudentEmail { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressRoadName { get; set; }
        public string AddressTown { get; set; }
        public string AddressCity { get; set; }
        public string AddressRegion { get; set; }
        public string AddressPostCode { get; set; }

        public List<ConvenorsDto> Convenors { get; set; }
        public List<EngagementsDto> Engagements { get; set; }
        public List<SocietysDto> Societies { get; set; }
        public List<SuggestionsDto> Suggestions { get; set; }
    }
}
