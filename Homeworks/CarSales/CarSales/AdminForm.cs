using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace CarSales
{ //pass the salt don't forget. Instantiate your things so you can have a properly updated AdminForm
    public partial class AdminForm : Form
    {
        Dealership dealershipsalt;
        CarDealership gotoform1pls;
        CarSale saleinformation;

        public AdminForm(Dealership dealership)
        {
            InitializeComponent();
            this.dealershipsalt = dealership;
            this.gotoform1pls = new CarDealership();
            
        }

        private void showAvCarsbtn_Click(object sender, EventArgs e)
        {
            availableCarslbx.Items.Clear();
            foreach (Car car in dealershipsalt.GetCars())
            {
                availableCarslbx.Items.Add(car);
            }

        }

        private void showSoldCarsbtn_Click(object sender, EventArgs e)
        {
            soldCarslbx.Items.Clear();
            foreach (CarSale car in dealershipsalt.GetSoldCars())
            {
                soldCarslbx.Items.Add(car);
            }

        }

        private void customerswitchbtn_Click(object sender, EventArgs e) //fuck this
        {
            Customer selectedcustomer = (Customer)customerslbx.SelectedItem;
            Debug.WriteLine("Empty");

            if (selectedcustomer != null) 
            {
                gotoform1pls.SetCustomer(selectedcustomer);
            }
            

        }

        private void customershowbtn_Click(object sender, EventArgs e)
        {
            customerslbx.Items.Clear();
            foreach (Customer cust in dealershipsalt.GetCustomers())
            {
                customerslbx.Items.Add(cust);
            }

        }
    }
}
