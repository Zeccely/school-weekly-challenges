using System.Diagnostics;

namespace CarSales
{
    public partial class CarDealership : Form
    {
        Dealership dealership = new Dealership("Toyoda");
        Customer buyer; 

        public CarDealership()
        {

            InitializeComponent();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {

            dealership.GetCars();

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
            carrzy = dealership.SearchCars(carBrandtbx.Text, carModeltbx.Text, carPricetbx.Text);
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
            DateTime Daymonthyear = new DateTime();
            DateTime purchasedaymonthyear = Daymonthyear.Date;
            
            dealership.SellCar((Car)foundCarscmbx.SelectedItem, buyer, ); //need to add datetime

        }

        private void addCustbtn_Click(object sender, EventArgs e)
        {
            string custname = custNametbx.Text.Trim();
            string phoneno = custNumtbx.Text.Trim();
            string address = custAddresstbx.Text.Trim();
            string zipcodecity = custzipcitytbx.Text.Trim();

            var result = dealership.AddCustomer(custname, phoneno, address, zipcodecity);

            if (result == true)
            {
                MessageBox.Show("Customer Added");
            }
            else
            {
                MessageBox.Show("Please fill in all the required data");
            }
          

        }
    }
}
