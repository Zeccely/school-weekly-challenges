using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarSales
{
    [DataContract]
    public class Dealership
    {
        private string name;
        CarSale Carsale;
        [DataMember]
        private List<Car> cars = new List<Car>();
        [DataMember]
        private List<CarSale> soldcars = new List<CarSale>();
        [DataMember]
        private List<Customer> customers = new List<Customer>();
       

        public Dealership(string name) 
        {
            this.name = name;
        }

        public Car? FindCar( string brand, string model, int year, double price)
        {
            foreach (Car car in cars)
            {
                if (car.Model.Equals(model) && car.Brand.Equals(brand) && car.Year.Equals(year) && car.Price.Equals(price))
                {
                    return car;
                }
            }
            return null;
        }
        public Car? FindAvailableCarID(int id)
        {
            foreach (Car car in cars)
            {
                if (car.ID.Equals(id))
                {
                    return car;
                }
            }
            return null;
        }
        public Customer? FindCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.ID.Equals(id))
                {
                    return c;
                }
            }
            return null;
        }
        public Car GetSoldCar(int id)
        {
            foreach (CarSale c in soldcars)
            {
                if (c.Soldcar.ID.Equals(id))
                {
                    return c.Soldcar;
                }
            }
            return null;
        }

        public string MarkdownLooper()
        {
            string markdownedcars = string.Empty; 
            foreach (CarSale soldcar in soldcars)
            {
                markdownedcars += $"{soldcar.Markdowner()}"; 
   
            }
            return markdownedcars;
           
        }
        public void SaveSoldCarsMD()
        {
            string markdownedcars = MarkdownLooper();
            
            string filepath;

            SaveFileDialog saver = new SaveFileDialog();
            
            

            if (saver.ShowDialog() == DialogResult.OK)
            {
                filepath = saver.FileName + ".md";
                File.WriteAllTextAsync(filepath, markdownedcars);

            }
        }

        public void GetCarsCSV() //databasehandler
        {

            OpenFileDialog openSesame = new OpenFileDialog();
            
            List<Car> copyofcars = new List<Car>();

            openSesame.Filter = "CSV Files |*.csv";
            
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
                        if (car == null)
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
            soldcars.Clear();
        }


        public List<Car> SearchCars(string brand, string model)/*, string price*/
        {
            List<Car> foundcars = new List<Car>();
            
            foundcars = FilterBrand(brand);
            foundcars = FilterModel(model, new List<Car>(foundcars));
            //foundcars = FilterPrice(price, new List<Car>(foundcars));   
            
            
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

        public List<Car> FilterPrice(string price, List<Car> filteredcars) //I do not really like how this works so I will not use it
        {
            List<Car> foundcars = new List<Car>();

            foreach (Car car in filteredcars)
            {
                string carprice = car.Price.ToString();
                if (carprice.Equals(price))
                {
                    foundcars.Add(car);
                }
            }
            return foundcars;
        }



        public List<CarSale> SellCar(Car car, Customer cust, DateTime dateofpurchase)
        {
            if (cars.Contains(car) && cust != null) 
            {
                CarSale newsale = new CarSale(car, cust, dateofpurchase);
                soldcars.Add(newsale);
                cars.Remove(car);
                  
            }
            else
            {
                MessageBox.Show("Car not sold: Customer is missing or car is already sold");
            }
          
        
            return soldcars;

        }

        public Customer AddCustomer(string name, string phoneno, string address, string zipcodecity)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneno) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(zipcodecity))
            {
                return null;
            }
            foreach (Customer c in customers)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.PhoneNo.Equals(phoneno, StringComparison.OrdinalIgnoreCase) && c.Address.Equals(address, StringComparison.OrdinalIgnoreCase) && c.ZipCodeCity.Equals(zipcodecity, StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }
            } 
    
            Customer customer = new Customer(name, phoneno, address, zipcodecity);
            customers.Add(customer);
            
            return customer; 
          
        }
    



        public List<Customer> GetCustomers()
        {
            List<Customer> customerscopy = new List<Customer>();
            foreach (Customer customer in customers)
            {
                customerscopy.Add(new Customer(customer.ID, customer.Name, customer.PhoneNo, customer.Address, customer.ZipCodeCity)); //this is le deep copies
            }
            return customerscopy;
        }
        public List<CarSale> GetSoldCars()
        {
            List<CarSale> soldCarscopy = new List<CarSale>(soldcars); //this is a shallowcopy
           
            return soldCarscopy;
        }
        public List<Car> GetCars()
        {
            List<Car> carscopy = new List<Car>();
            foreach (Car car in cars)
            {
                carscopy.Add(new Car(car.Brand, car.Model, car.Year, car.Price));
            }
            return carscopy;
        }

        public void SetCars(List<Car> c)
        {
            cars = c;
        }

        public void SetSoldCars(List<CarSale> soldc)
        {
            soldcars = soldc;
        }

        public void SetCustomer(List<Customer> customers)
        {
            this.customers = customers;
            
        }
        

        
        
        


    }
}
