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
        public bool CarCheck(string brand, string model, int year, double price)
        {
            foreach (Car car in cars)
            {
                if (car.Brand == brand && car.Model==model && car.Year == year && car.Price == price)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Car> GetCars()
        {
            OpenFileDialog openSesame = new OpenFileDialog();
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
                    List<Car> comparisonlist = new List<Car>();

                    while (!streamReader.EndOfStream)
                    {
                        

                        renamethis = streamReader.ReadLine();
                        string[] renamethisaswell = renamethis.Split(",");
                        carBrand = renamethisaswell[0];
                        carModel = renamethisaswell[1];
                        carYear = Convert.ToInt32(renamethisaswell[2]);
                        carPrice = Convert.ToDouble(renamethisaswell[3]); 
                        

                        Car car = new Car(carBrand, carModel, carPrice);
                        comparisonlist.Add(car);


                        
                       
                    }

                    if (CarCheck(carBrand, carModel, carYear, carPrice) == false)
                    {
                        cars.Add(car);
                    }
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
            return cars;
        }
    }
}
