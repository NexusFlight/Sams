using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class StudentEngagement
    {
        public Students Student { get; set; }
        public Guid StudentGuid { get; set; }

        public Engagements Engagement { get; set; }
        public Guid EngagementID { get; set; }
    }
}
