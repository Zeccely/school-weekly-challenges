using System.Diagnostics;

namespace CarSales
{
    public partial class CarDealership : Form
    {
        Dealership dealership = new Dealership("Toyoda");


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
    }
}
