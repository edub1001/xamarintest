using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTest.Model
{
    public class Campaign
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public SynchronizationStatus Forms { get; set; }

        public SynchronizationStatus Employees { get; set; }
    }
}
