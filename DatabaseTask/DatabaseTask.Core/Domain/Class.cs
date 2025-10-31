using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        public int ClassID { get; set; }
        public string Tunnus { get; set; }
        public IEnumerable<Teacher> Klassijuhataja { get; set; }
    }
}
