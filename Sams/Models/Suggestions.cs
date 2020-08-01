using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Suggestions
    {
        public Guid SuggestionID { get; set; }
        public string SuggestionType { get; set; }
        public string SuggestionDetails { get; set; }
        public bool SuggestionHandlingAnonymity { get; set; }
        public DateTime SuggestionSubmissionDateTime { get; set; }
        public List<StudentSuggestion> StudentSuggestions { get; set; }

    }
}
