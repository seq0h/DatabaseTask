using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Subjekt> Subjekts { get; set; }
        public string Email { get; set; }
    }
}
