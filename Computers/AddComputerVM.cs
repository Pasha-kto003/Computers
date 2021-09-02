using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class AddComputerVM : BaseNotify
    {
        public List<Computer> Computers { get; set; }
        private Computer selectedComputer;
        private Group selectedGroup;

        public int IPAdress { get; set; }
        public string Domenname { get; set; }
        public int Inventorynumber { get; set; }
        public int Macadress { get; set; }

        public void AddComputer(int ip, string domenName, int inventoryNumber, int macAdress, Group group)
        {
            Computer computer = new Computer
            {
                IP = ip,
                DomenName = domenName,
                InventoryNumber = inventoryNumber,
                MacAdress = macAdress,
                GroupID = group.ID
            };
            Computers.Add(computer);
            
        }
        public List<Group> Groups { get; set; }
        public Computer SelectedComputer { get => selectedComputer; set { selectedComputer = value; OnPropertyChanged(); } }
        public Group SelectedGroup { get => selectedGroup; set { selectedGroup = value; OnPropertyChanged(); } }
        public RelayCommand SaveComputer { get; set; }

        public AddComputerVM(MainViewModel mainVM)
        {
            Groups = new List<Group>();
            SaveComputer = new RelayCommand(() =>
            {
                AddComputer(IPAdress, Domenname, Inventorynumber, Macadress, SelectedGroup);
                mainVM.CurrentView = new ComputerView(mainVM);
            });
        }
    }
}
