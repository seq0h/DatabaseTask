using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public char Isikukood { get; set; }
        public IEnumerable<Class> Class { get; set; }
        public string Email { get; set; }
    }
}
