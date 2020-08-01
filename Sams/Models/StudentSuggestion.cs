using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class StudentSuggestion
    {
        public Students Student { get; set; }
        public Guid StudentGuid { get; set; }

        public Suggestions Suggestion { get; set; }
        public Guid SuggestionID { get; set; }
    }
}
