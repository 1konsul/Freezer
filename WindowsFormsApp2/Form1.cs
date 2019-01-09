using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Appliance appliance;
        Freezer freezer1;
        Freezer freezer2;
        Oven oven;
        List<Appliance> appliances;

        public Form1()
        {
            InitializeComponent();
            appliances = new List<Appliance>();
            appliance = new Oven("oven big", 200,200);
            freezer1 = new Freezer("freezer type freezer", 122,-10);
            freezer2 = new Freezer("freezer type freezer", 155, -20);
            oven = new Oven("oven", 222, 500);
            appliances.Add(appliance);
            appliances.Add(freezer1);
            appliances.Add(freezer2);
            appliances.Add(oven);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (Appliance item in appliances)
            {
                if(item is IFreeze)
                {
                    message += item.WhoAmI();
                    IFreeze newRef;
                    newRef = item as IFreeze;
                    message+=newRef.Freeze()+"\r\n";
                }
                else
                {
                    message+= "I am a "+item.Description+" and my power consumption is: "+item.PowerConsumption+"\r\n";
                }
            }
            label1.Text = message;
        }
    }
}
