using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class GroupVM : BaseNotify
    {
        public ObservableCollection<Group> Groups { get; set; }
        public RelayCommand AddGroup { get; set; }
        public RelayCommand EditGroup { get; set; }

        public GroupVM(MainViewModel mainVM)
        {
            AddGroup = new RelayCommand(() =>
            {
                mainVM.CurrentView = new AddGroupView(mainVM);
            });
        }
    }
}
