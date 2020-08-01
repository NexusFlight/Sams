
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models.Dtos
{
    public class SuggestionsDto
    {
        public Guid SuggestionID { get; set; }
        public string SuggestionType { get; set; }
        public string SuggestionDetails { get; set; }
        public string SuggestionHandlingAnonymity { get; set; }
        public DateTime SuggestionSubmissionDateTime { get; set; }

        [JsonIgnore]
        public List<StudentsDto> Students { get; set; }
    }
}
