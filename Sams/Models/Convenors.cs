using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Convenors
    {
        public Guid ConvenorID { get; set; }
        public string ConvenorType { get; set; }
        public bool ConvenorTrainingTaken { get; set; }
        public string ConvenorPVGStatus { get; set; }


        public List<SocietyConvenor> SocietyConvenors { get; set; }
        public List<StudentConvenor> StudentConvenors { get; set; }
    }
}
