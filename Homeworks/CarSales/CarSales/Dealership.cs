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

        string name;
        public List<Car> cars = new List<Car>();
        

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
                    string renamethis = streamReader.ReadLine();
                    Debug.WriteLine(renamethis);

                    string carBrand;
                    string carModel;
                    int carYear;
                    double carPrice;
      
                    while (!streamReader.EndOfStream)
                    {
                        renamethis = streamReader.ReadLine();
                        string[] renamethisaswell = renamethis.Split(",");
                        carBrand = renamethisaswell[0];
                        carModel = renamethisaswell[1];
                        carYear = Convert.ToInt32(renamethisaswell[2]);
                        carPrice = Convert.ToDouble(renamethisaswell[3]);
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
        }
    }
}
