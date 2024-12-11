using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {
        Bakery bakery = new Bakery("Bakary");   
        public AddForm(Bakery b)
        {
            InitializeComponent();
            BreadFilter.DataSource = Enum.GetValues(typeof(BreadType));
        }

        public void BreadAdder_Click(object sender, EventArgs e)
        {
            string sandoName = (sandwichName.Text.ToString());
            double sandoPrice = 4;
            BreadType typeFilter = (BreadType)BreadFilter.SelectedItem;
            Sandwich sandwich = new Sandwich(sandoName, sandoPrice, typeFilter);
            bakery.AddSandwitch(sandwich);
        }
        
      
    }
}
