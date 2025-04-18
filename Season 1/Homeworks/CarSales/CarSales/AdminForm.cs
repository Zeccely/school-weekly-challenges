﻿using System;
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
                if (dealership.GetCarID(car.ID) != null)
                {
                    availableCarslbx.Items.Add(car);
                }
                
            }

        }

        private void showSoldCarsbtn_Click(object sender, EventArgs e)
        {
            soldCarslbx.Items.Clear();
            if (dealership.GetSoldCars() != null) 
            {
                foreach (CarSale car in dealership.GetSoldCars())
                {
                    if (dealership.GetSoldCarID(car.Soldcar.ID) != null)
                    {
                        soldCarslbx.Items.Add(car);
                    }
                }
            }

            

        }

        private void customerswitchbtn_Click(object sender, EventArgs e) 
        {
            Customer selectedcustomer = (Customer)customerslbx.SelectedItem;

            if (selectedcustomer != null) 
            {
                cardealershipform.SetCustomerInst(selectedcustomer);
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
