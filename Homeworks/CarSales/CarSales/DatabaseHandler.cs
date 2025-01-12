using System;
using System.Collections.Generic;
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
        string Databasestring = " Data Source=.\\sqlexpress;Initial Catalog=DealershipData;Integrated Security=True;Trust Server Certificate=True ";



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

                    if (cars1.Count > 0)
                    {
                        car = dealershipdata.FindCar(Brand, Model, Year, pricedouble);
                    }
                    if (car == null)
                    {
                        car = new Car(Brand, Model, Year, pricedouble);
                    }

                    cars1.Add(car);

                }
                return cars1;


            }
            return null;
            
            
        }
        public void AddCustomerData(string name, string phoneno, string address, string zipcodecity)
        {

            string query = $"Insert into Customer (Name, PhoneNo, Address, ZipCodeCity) Values ({name}, {phoneno}, {address}, {zipcodecity});";
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

        }
        public void GetCustomerData()
        {
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
            }
            using SqlCommand command = new SqlCommand(query, sqlConnection);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                List<Customer> cust1 = dealershipdata.GetCustomers();
                while (reader.Read())
                {
                    
                    string name = reader.GetString(0);
                    string phoneno = reader.GetString(1);
                    string address = reader.GetString(2);
                    string zipcodecity = reader.GetString(3);

                }

            }

        }
    }
}
