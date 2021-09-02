using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class AddGroupVM : BaseNotify
    {
        public ObservableCollection<Group> Groups { get; set; }
        public int IDGroup { get; set; }
        public int NumberGroup { get; set; }
        public List<Computer> Computers { get; set; }

        public void AddGroup(int id, int number)
        {
            Group group = new Group
            {
                ID = id,
                Number = number
            };
            Groups.Add(group);
        }

        public RelayCommand SaveGroup { get; set; }

        public AddGroupVM(MainViewModel mainVM)
        {
            Groups = new ObservableCollection<Group>();
            OnPropertyChanged("Groups");
            SaveGroup = new RelayCommand(() =>
            {
                AddGroup(IDGroup, NumberGroup);
                mainVM.CurrentView = new GroupView(mainVM);
            });
        }
    }
}
