using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class ComputerVm : BaseNotify
    {
        public ObservableCollection<Computer> Computers { get; set; }
        public RelayCommand AddComputer { get; set; }
        public ComputerVm(MainViewModel mainVM)
        {
            List<Computer> Computers = new List<Computer>();
            AddComputer = new RelayCommand(() =>
            {
                mainVM.CurrentView = new AddComputerView(mainVM);
            });
        }

        
    }
}
