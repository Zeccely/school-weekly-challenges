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
    public partial class MainForm : Form
    {
        Bakery bakery = new Bakery("Bakary");
        public MainForm()
        {
            InitializeComponent();

            // Init GUI
            lblSandwichInfo.Text = String.Empty;
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e) //use the overloaded methods to take the sandwich list and display it
        {
            List<Sandwich> SandwichDisplay = new List<Sandwich>();
            SMenu.Items.Clear();


            foreach (Sandwich s in SandwichDisplay) 
            {
                SMenu.Items.Add(s);
            }
            
            
           
        }

        private void AddSandwich_Click(object sender, EventArgs e)
        {
            Form BreadAddForm = new AddForm(bakery);
            BreadAddForm.Show();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            
        }
    }
}
