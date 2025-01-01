using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    internal class Dealership
    {

        private string name;
        public DateTime DateOfPurchase { get; private set; }
        private List<Car> cars = new List<Car>();
        private List<Car> soldcars = new List<Car>();
        List<Customer> customers = new List<Customer>();

        public Dealership(string name) 
        {
            this.name = name;
        }
        
        public Car FindCar(string brand, string model, int year, double price)
        {
            foreach (Car car in cars)
            {
                Debug.WriteLine(car.Model);
                Debug.WriteLine(model);
                if (car.Model.Equals(model) && car.Brand.Equals(brand) && car.Year.Equals(year) && car.Price.Equals(price))
                {
                    return car;
                }
            }
            return null;
        }

        public void GetCars()
        {

            OpenFileDialog openSesame = new OpenFileDialog();
            List<Car> copyofcars = new List<Car>();
            //create a condition for the dialog to limit the type to csv only
            if (openSesame.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(File.OpenRead(openSesame.FileName));
                try
                {
                    string incomingcsv = streamReader.ReadLine();
                    Debug.WriteLine(incomingcsv);

                    string carBrand;
                    string carModel;
                    int carYear;
                    double carPrice;
      
                    while (!streamReader.EndOfStream)
                    {
                        incomingcsv = streamReader.ReadLine();
                        string[] cardatacsv = incomingcsv.Split(",");
                        carBrand = cardatacsv[0];
                        carModel = cardatacsv[1];
                        carYear = Convert.ToInt32(cardatacsv[2]);
                        carPrice = Convert.ToDouble(cardatacsv[3]);
                        Car car = null;

                        
                        if (cars.Count > 0 )
                        {
                            car = FindCar(carBrand, carModel, carYear, carPrice);
                        }
                        if (car == null && !soldcars.Contains(car))
                        {
                            car = new Car(carBrand, carModel, carYear, carPrice);
                        }
                        
                        copyofcars.Add(car);
                        


                    }
                      cars = copyofcars; 

                    
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    streamReader?.Close();
                }
                
            }
           
        }
        public void ClearData()
        {
            cars.Clear();
            customers.Clear();
        }


        public List<Car> SearchCars(string brand, string model, string price)
        {
            List<Car> foundcars = new List<Car>();
            
            foundcars = FilterBrand(brand);
            foundcars = FilterModel(model, new List<Car>(foundcars));
            foundcars = FilterPrice(price, new List<Car>(foundcars));    
            
            return foundcars;
          
        }

        public List<Car> FilterBrand(string brand)
        {
            List<Car> foundcars = new List<Car>();

            foreach (Car car in cars)
            {

                if (car.Brand.Contains(brand, StringComparison.OrdinalIgnoreCase))
                {
                    foundcars.Add(car);
                }

            }
            Debug.WriteLine(foundcars);
            return foundcars;

        }
        public List<Car> FilterModel(string model, List<Car> filteredcars)
        {
            List<Car> foundcars = new List<Car>();

            foreach(Car car in filteredcars)
            {
                if (car.Model.Contains(model, StringComparison.OrdinalIgnoreCase))
                {
                    foundcars.Add(car);
                }
            }
            return foundcars;
        }

        public List<Car> FilterPrice(string price, List<Car> filteredcars)
        {
            List<Car> foundcars = new List<Car>();

            foreach (Car car in filteredcars)
            {
                string carprice = car.Price.ToString();
                if (carprice.Contains(price))
                {
                    foundcars.Add(car);
                }
            }
            return foundcars;
        }



        public List<Car> SellCar(Car car, Customer cust, DateTime dateofpurchase)
        {
            if (cars.Contains(car)) 
            {
                soldcars.Add(car);
                cars.Remove(car);
            }
        
            return soldcars;

        }

        public bool AddCustomer(string name, string phoneno, string address, string zipcodecity)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneno) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(zipcodecity))
            {
                return false;
            }
    
            Customer customer = new Customer(name, phoneno, address, zipcodecity);
            customers.Add(customer);

            return true; 
          
        }

        public string Markdowner(Car c, Customer cust)
        {
            return $" # {c.dateOfPurchase} | {c.Brand} {c.Model} ({c.Year})\n -*Price*: {c.Price}\n -*Customer*: {cust.name}\n -*Phone no.*: {cust.phoneNo}\n -*Address*: {cust.address}\n -*Zip code & city*: {cust.zipCodeCity}\n ---";
        }
    }//what is $@ never heard of her 
}
