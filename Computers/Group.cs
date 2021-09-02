using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Group
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public List<Computer> Computers { get; set; }
    }
}
