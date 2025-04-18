using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization;
using System.Xml;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace CarSales
{
    public partial class DealershipForm: Form
    {
        Dealership dealership = new Dealership("Toyoda");
        Customer customer;
        FileHandler filesStuff;
        DatabaseHandler databaseHandler;

        public DealershipForm()
        {

            InitializeComponent();
            filesStuff = new FileHandler(dealership);
            buyernamlbl.Text = string.Empty;
            databaseHandler = new DatabaseHandler(dealership);
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            
            dealership.SetCars(databaseHandler.GetCarsData());
            dealership.SetCustomer(databaseHandler.GetCustomerData());
            dealership.SetSoldCars(databaseHandler.GetSoldCarsData()); 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dealership.ClearData();
        }

        private void carSearchbtn_Click(object sender, EventArgs e)
        {
            List<Car> carlist = new List<Car>();
            cardetailstbx.Text = string.Empty;
            foundCarscmbx.Items.Clear();
            carlist = dealership.SearchCars(carBrandtbx.Text, carModeltbx.Text);/*carPricetbx.Text*/
            foreach (Car cars in databaseHandler.GetCarsData())
            {
                foundCarscmbx.Items.Add(cars);
            }
        }

        private void foundCarscmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardetailstbx.Text = string.Empty;
            try
            {
                Car selectedcar = (Car)foundCarscmbx.SelectedItem;
                cardetailstbx.Text = selectedcar.GetDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Car already sold");
            }

        }

        private void sellCarbtn_Click(object sender, EventArgs e)
        {
            DateTime Daymonthyear = DateTime.Today;
            Car selectedcar = (Car)foundCarscmbx.SelectedItem;
            dealership.SellCar(selectedcar, customer, Daymonthyear);
            databaseHandler.SellCar(customer, selectedcar, Daymonthyear);

            List<Car> carlist = new List<Car>();
            cardetailstbx.Text = string.Empty;
            carlist = dealership.SearchCars(carBrandtbx.Text, carModeltbx.Text);
            foundCarscmbx.Items.Clear();
            foundCarscmbx.Text = string.Empty;
            foreach (Car cars in databaseHandler.GetCarsData())
            {
                foundCarscmbx.Items.Add(cars);
            }
            
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(this.dealership, this);
            adminForm.Show();
        }

        public void SetCustomerInst(Customer cust)
        {
            this.customer = cust;
            Debug.WriteLine(customer.ToString());
            buyernamlbl.Text = cust.Name;
        }

        private void addcustbtn_Click(object sender, EventArgs e)
        {
           
            string custname = custNametbx.Text.Trim();
            string phoneno = custNumtbx.Text.Trim();
            string address = custAddresstbx.Text.Trim();
            string zipcodecity = custzipcitytbx.Text.Trim();   
            databaseHandler.AddCustomerData(custname, phoneno, address, zipcodecity);

            if (databaseHandler.GetCustomerData() == null)
            {
                MessageBox.Show("Please fill in all requirements or this person already exists");
            }
            else
            {
                MessageBox.Show("Customer added successfully!");
                custNametbx.Text = string.Empty;
                custNumtbx.Text = string.Empty;
                custAddresstbx.Text = string.Empty;
                custzipcitytbx.Text = string.Empty;
                dealership.SetCustomer(databaseHandler.GetCustomerData());
            }
        }
        private void SaveData_Click(object sender, EventArgs e)
        {
            dealership.SaveSoldCarsMD();
        }

        private void loadxmlbtn_Click(object sender, EventArgs e) 
        {
            filesStuff.LoadAllDataXML();
            this.dealership = filesStuff.GetDealershipinfo();
        }

        private void savexmlbtn_Click(object sender, EventArgs e)
        {
            filesStuff.SaveAllDataXML();
        }

        private void SaveJSONbtn_Click(object sender, EventArgs e)
        {
            filesStuff.SaveAllDataJson();
        }

        private void LoadJSONbtn_Click(object sender, EventArgs e)
        {
            filesStuff.LoadAllDataJson();
            this.dealership = filesStuff.GetDealershipinfo();
        }
    }
}
