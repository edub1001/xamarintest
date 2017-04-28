using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinTest.Model;

namespace XamarinTest.ViewModel
{
    public class CampaignViewModel : ViewModelBase
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public SynchronizationStatus Forms { get; set; }

        public SynchronizationStatus Employees { get; set; }

        public string FormsSynchedImage
        {
            get
            {
                if (Forms == SynchronizationStatus.Synched)
            }           
        }
    }
}
