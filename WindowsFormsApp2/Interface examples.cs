using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    interface IFreeze
    {
        string Freeze();// this is test comment
        
        int FreezingTemperature { get; set; }
    }

    abstract class Appliance
    {
        public Appliance(string description, int powerConsumption)
        {
            Description = description;
            PowerConsumption = powerConsumption;
        }
        internal virtual string WhoAmI()
        {
            return "I am a base class appliance\r\n";
        }

        public string Description { get; set; }
        public int PowerConsumption { get; set; }
        
    }
    class Oven : Appliance
    {
        public Oven(string description, int powerConsumption, int capacity) : base(description, powerConsumption)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }
        internal override string WhoAmI()
        {
            return "I am an oven and I am derived from: \r\n"+base.WhoAmI();
        }

    }
    class Freezer : Appliance, IFreeze
    {
        public Freezer(string description, int powerConsumption, int freezingTemp) : base(description, powerConsumption)
        {
            FreezingTemperature = freezingTemp;
        }

        public int FreezingTemperature { get ; set ; }

        internal override string WhoAmI()
        {
            return "I am freezer and I am derived from: \r\n" + base.WhoAmI();
        }
        public string Freeze()
        {
            return "I am a freezer and my freezing temp is: "+FreezingTemperature;
        }
    }
}
