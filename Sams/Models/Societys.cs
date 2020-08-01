using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Societys
    {
        public Guid SocietyID { get; set; }
        public string SocietyName { get; set; }
        public string SocietyRunningTimes { get; set; }

        public List<SocietyConvenor> SocietyConvenors { get; set; }
        public List<StudentSociety> StudentSocieties { get; set; }
    }
}
