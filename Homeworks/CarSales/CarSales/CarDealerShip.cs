using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization;
using System.Xml;

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

        private void sellCarbtn_Click(object sender, EventArgs e)
        {


            DateTime Daymonthyear = DateTime.Today;
            Car selectedcar = (Car)foundCarscmbx.SelectedItem;
            dealership.SellCar(selectedcar, customer, Daymonthyear);

        }



        private void adminbtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(this.dealership, this);
            adminForm.Show();
        }

        public void SetCustomer(Customer cust)
        {
            this.customer = cust;
            Debug.WriteLine(customer.ToString());
            buyernamlbl.Text = cust.name;
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            dealership.SaveSoldCarsMD();
        }

        private void addcustbtn_Click(object sender, EventArgs e)
        {
            string custname = custNametbx.Text.Trim();
            string phoneno = custNumtbx.Text.Trim();
            string address = custAddresstbx.Text.Trim();
            string zipcodecity = custzipcitytbx.Text.Trim();

            Customer result = dealership.AddCustomer(custname, phoneno, address, zipcodecity);

            if (result == null)
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

            }

        }
        
       
        public void SaveAllDataJson()
        {

        }

        public void LoadAllDataJson()
        {

        }

        private void loadxmlbtn_Click(object sender, EventArgs e) //try to method this later
        {
            string filename;
            FileStream fs = null;
            OpenFileDialog saverAll = new OpenFileDialog();

            if (saverAll.ShowDialog() == DialogResult.OK)
            {
                filename = saverAll.FileName;
                try
                {
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    Type Cardealership = typeof(Dealership);
                    List<Type> auxtype = new List<Type> { typeof(Car), typeof(CarSale), typeof(Customer) };
                    DataContractSerializer dcs = new DataContractSerializer(Cardealership, auxtype);
                    dealership = (Dealership)dcs.ReadObject(reader);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You canceled it");
            }
        }

        private void savexmlbtn_Click(object sender, EventArgs e)
        {
            dealership.SaveAllDataXML();
        }
    }
}
