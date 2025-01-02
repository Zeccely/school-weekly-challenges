using System.Diagnostics;

namespace CarSales
{
    public partial class CarDealership : Form
    {
        Dealership dealership = new Dealership("Toyoda");
        Customer customer;
        

        public CarDealership()
        {

            InitializeComponent();
            
            buyernamlbl.Text = string.Empty;
        }

        private void LoadData_Click(object sender, EventArgs e)
        {

            dealership.GetCarsCSV();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dealership.ClearData();
        }


        private void carSearchbtn_Click(object sender, EventArgs e)
        {
            List<Car> carrzy = new List<Car>();
            cardetailstbx.Text = string.Empty;
            foundCarscmbx.Items.Clear();
            carrzy = dealership.SearchCars(carBrandtbx.Text, carModeltbx.Text);/*carPricetbx.Text*/
            foreach (Car vroom in carrzy)
            {

                foundCarscmbx.Items.Add(vroom);

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
                Console.WriteLine(ex.Message);
            }

        }

        private void sellCarbtn_Click(object sender, EventArgs e) //can only sell a car if customer data is filled in
        {
            string custname = custNametbx.Text.Trim();
            string phoneno = custNumtbx.Text.Trim();
            string address = custAddresstbx.Text.Trim();
            string zipcodecity = custzipcitytbx.Text.Trim();

            
            Customer result = dealership.AddCustomer(custname, phoneno, address, zipcodecity);

            if (result == null)
            {
                MessageBox.Show("Please fill in all requirements");
            }
            else
            {
                MessageBox.Show("Customer added successfully!");

            }

            DateTime Daymonthyear = DateTime.Today;
            Car selectedcar = (Car)foundCarscmbx.SelectedItem;
            dealership.SellCar(selectedcar, result, Daymonthyear);
            this.customer = result;

        }

        //private void addCustbtn_Click(object sender, EventArgs e)
        //{
        //    string custname = custNametbx.Text.Trim();
        //    string phoneno = custNumtbx.Text.Trim();
        //    string address = custAddresstbx.Text.Trim();
        //    string zipcodecity = custzipcitytbx.Text.Trim();

        //    Customer result = dealership.AddCustomer(custname, phoneno, address, zipcodecity);

        //    if (result == null)
        //    {
        //        MessageBox.Show("Please fill in all requirements");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Customer added successfully!");

        //    }
            


        //}

        private void adminbtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(this.dealership);
            adminForm.Show();
        }

        public void SetCustomer(Customer cust)
        {
            this.customer = cust;
            Debug.WriteLine(customer.ToString());
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            dealership.SaveCarsMD();
        }
    }
}
