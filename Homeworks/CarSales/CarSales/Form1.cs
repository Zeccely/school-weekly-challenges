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
    }
}
