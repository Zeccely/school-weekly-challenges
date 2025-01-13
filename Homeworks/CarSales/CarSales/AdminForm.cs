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
{ 

    public partial class AdminForm : Form 
    {
        Dealership dealership;
        DealershipForm cardealershipform;
        

        public AdminForm(Dealership dealership, DealershipForm gototheform)
        {
            InitializeComponent();
            this.dealership = dealership;
            this.cardealershipform = gototheform;
            
        }

        private void showAvCarsbtn_Click(object sender, EventArgs e)
        {
            availableCarslbx.Items.Clear();
            foreach (Car car in dealership.GetCars())
            {
                availableCarslbx.Items.Add(car);
            }

        }

        private void showSoldCarsbtn_Click(object sender, EventArgs e)
        {
            soldCarslbx.Items.Clear();

            foreach (CarSale car in dealership.GetSoldCars())
            {
                
                soldCarslbx.Items.Add(car);
            }

        }

        private void customerswitchbtn_Click(object sender, EventArgs e) 
        {
            Customer selectedcustomer = (Customer)customerslbx.SelectedItem;
            Debug.WriteLine("Empty");

            if (selectedcustomer != null) 
            {
                cardealershipform.SetCustomer(selectedcustomer);
            }
            

        }

        private void customershowbtn_Click(object sender, EventArgs e)
        {
            customerslbx.Items.Clear();
            foreach (Customer cust in dealership.GetCustomers())
            {
                customerslbx.Items.Add(cust);
            }

        }

    }
}
