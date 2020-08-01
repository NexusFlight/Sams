using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class SocietyConvenor
    {

        public Societys Society { get; set;}
        public Guid SocietyID { get; set; }
        public Convenors Convenor { get; set; }
        public Guid ConvenorID { get; set; }
    }
}
