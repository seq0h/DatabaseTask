using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Grades
    {
        public int GradesID { get; set; }
        public IEnumerable<Student> Student { get; set; }
        public IEnumerable<Teacher> Teacher { get; set; }
        public int Hinne {  get; set; } 
        public DateOnly Date {  get; set; }
        public IEnumerable<Subjekt> Subjekt { get; set; }
    }
}
