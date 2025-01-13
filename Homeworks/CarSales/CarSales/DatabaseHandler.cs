using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarSales
{
    public class DatabaseHandler
    {
        Dealership dealershipdata;
        string Databasestring = "Data Source=.\\sqlexpress;Initial Catalog=DealershipData;Integrated Security=True;Trust Server Certificate=True";



        public DatabaseHandler(Dealership dealership)
        {
            dealershipdata = dealership;
        }

        public List<Car> GetCarsData()
        {
            string query = "Select * From Car";
            using SqlConnection sqlConnection = new SqlConnection(Databasestring);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("There was an error, No database connected");
                return null;
            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                List<Car> cars1 = dealershipdata.GetCars();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Brand = reader.GetString(1);
                    string Model = reader.GetString(2);
                    int Year = reader.GetInt16(3);
                    decimal Price = reader.GetDecimal(4);
                    double pricedouble = Convert.ToDouble(Price);

                    Car car = new Car(Brand, Model, Year, pricedouble);
                    car.SetID(Id);

                    if (cars1.Count > 0)
                    {
                        car = dealershipdata.FindCar(Brand, Model, Year, pricedouble);
                    }
                    if (car == null)
                    {
                        car = new Car(Brand, Model, Year, pricedouble);
                        car.SetID(Id);
                    }

                    cars1.Add(car);

                }
                return cars1;


            }
            return null;


        }
        public void AddCustomerData(string name, string phoneno, string address, string zipcodecity)
        {

            string query = $"Insert into Customer (Name, Phoneno, Address, Zipcodecity) Values ('{name}', '{phoneno}', '{address}', '{zipcodecity}');";
            using SqlConnection sqlConnection = new SqlConnection(Databasestring);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Database not connected, Check console");
            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }
        public List<Customer> GetCustomerData()
        {
            List<Customer> cust1 = new List<Customer>();
            string query = "Select * From Customer";
            using SqlConnection sqlConnection = new SqlConnection(Databasestring);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Database not connected, Check console");
                return null;
            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read()) //you know the customer exists because it comes from the database.
                {

                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string phoneno = reader.GetString(2);
                    string address = reader.GetString(3);
                    string zipcodecity = reader.GetString(4);

                    Customer customertemp = new Customer(name, phoneno, address, zipcodecity);
                    customertemp.SetID(id);
                    
                    

                }

                return cust1;

            }
            return null;

        }
        public void SellCar(Customer cust, Car car, DateTime dateofpurchase)
        {
            dateofpurchase = DateTime.Today;
            string query = $"Insert Into CarSale (CustomerID, CarID, DateofPurchase) Values ('{cust.ID}', '{car.ID}', '{ dateofpurchase: dd MMMM yyyy}') ";
            using SqlConnection sqlConnection = new SqlConnection(Databasestring);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Database not connected, Check console");

            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }

        public List<CarSale> GetSoldCarsData()
        {
            List<CarSale> soldcars = new List<CarSale>();
            
            string query = $" Select * From Customer as cus INNER JOIN CarSale as cs on cus.Id = cs.CustomerID INNER JOIN Car as c on c.Id = cs.CarID ";
            using SqlConnection sqlConnection = new SqlConnection(Databasestring);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Database not connected, Check console");
                return null;
            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int customerid = reader.GetInt32(0);
                    string customername = reader.GetString(1);
                    int carid = reader.GetInt32(6);
                    DateTime dateofpurchase = reader.GetDateTime(7);
                    string carbrand = reader.GetString(9);
                    string carmodel = reader.GetString(10);
                    int caryear = reader.GetInt16(11);
                    double carprice = Convert.ToDouble(reader.GetDecimal(12));

                    Customer buyer = dealershipdata.FindCustomer(customerid);
                    Car purchasedcar = new Car(carid, carbrand, carmodel, caryear, carprice);

                    CarSale soldcar = new CarSale(purchasedcar, buyer, dateofpurchase);
                    soldcars.Add(soldcar);
                    
                }
                return soldcars;
            }
            return null;
        }
    }
}
