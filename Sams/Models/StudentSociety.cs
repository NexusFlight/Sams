using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class StudentSociety
    {
        public Students Students { get; set; }
        public Guid StudentGuid { get; set; }

        public Societys Society { get; set; }
        public Guid SocietyID { get; set; }
    }
}
