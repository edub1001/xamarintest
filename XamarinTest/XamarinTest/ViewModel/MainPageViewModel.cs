using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinTest.Model;

namespace XamarinTest.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private Campaign[] _campaigns;

        public Campaign[] Campaigns {
            get
            {
                return _campaigns;
            }

            set
            {
                _campaigns = value;
                OnPropertyChanged("Campaigns");
            }
        }

        public MainPageViewModel()
        {
            Campaigns = new Campaign[]
            {
                new Campaign { Name = "Campaign 1", Company = new Company { Name = "Cognizant" }, Employees = SynchronizationStatus.Synched, Forms = SynchronizationStatus.NotSynched },
                new Campaign { Name = "Campaign 2", Company = new Company { Name = "Cognizant" }, Employees = SynchronizationStatus.NotSynched, Forms = SynchronizationStatus.NotSynched },
                new Campaign { Name = "Campaign 3", Company = new Company { Name = "Cognizant" }, Employees = SynchronizationStatus.NotSynched, Forms = SynchronizationStatus.Synched }
            };
        }
    }
}
