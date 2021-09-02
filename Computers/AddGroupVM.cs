using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class AddGroupVM : BaseNotify
    {
        List<Group> Groups { get; set; }
        public int IDGroup { get; set; }
        public int NumberGroup { get; set; }
        public List<Computer> Computers { get; set; }

        public void AddGroup(int id, int number)
        {
            Group group = new Group
            {
                ID = 1,
                Number = 20,
                Computers = new List<Computer>()
            };
            Groups.Add(group);
        }

        public RelayCommand SaveGroup { get; set; }

        public AddGroupVM(MainViewModel mainVM)
        {
            SaveGroup = new RelayCommand(() =>
            {
                AddGroup(IDGroup, NumberGroup);
                mainVM.CurrentView = new GroupView(mainVM);
            });
        }
    }
}
