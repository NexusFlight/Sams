using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class StudentConvenor
    {
        public Students Students { get; set; }
        public Guid StudentGuid { get; set; }

        public Convenors Convenor { get; set; }
        public Guid ConvenorID { get; set; }
    }
}
