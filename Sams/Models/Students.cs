using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Students
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

        public List<StudentEngagement> StudentEngagements { get; set; }
        public List<StudentSociety> StudentSocieties { get; set; }
        public List<StudentSuggestion> StudentSuggestions { get; set; }
        public List<StudentConvenor> StudentConvenors { get; set; }
    }

   



    

    

    
}
