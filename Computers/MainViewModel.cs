using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Computers
{
    public class MainViewModel : BaseNotify
    {
        private Page currentView;
        public Page CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged("CurrentView"); }
        }
        public RelayCommand OpenComputers { get; set; }
        public RelayCommand OpenGroup { get; set; }
        public MainViewModel()
        {
            OpenComputers = new RelayCommand(() =>
            {
                CurrentView = new ComputerView(this);
            });
            OpenGroup = new RelayCommand(() =>
            {
                CurrentView = new GroupView(this);
            });
        }
    }
}
