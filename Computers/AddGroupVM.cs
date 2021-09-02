using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class AddGroupVM : BaseNotify
    {
        private Group selectedGroup;
        public int IDGroup { get; set; }
        public int Number { get; set; }
        public AddGroupVM(MainViewModel mainVM)
        {

        }
    }
}
