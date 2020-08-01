using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Engagements
    {
        public Guid EngagementID { get; set; }
        public string EngagementType { get; set; }
        public string EngagementDetails { get; set; }
        public DateTime EngagementDateTime { get; set; }
        public string AwardAchieved { get; set; }

        public List<StudentEngagement> StudentEngagements { get; set; }

    }
}
