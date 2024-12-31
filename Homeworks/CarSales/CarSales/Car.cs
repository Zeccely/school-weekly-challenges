using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    internal class Car
    {
        public string Brand {  get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Price { get; private set; }
        

        public Car(string brand, string model, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }
        public Car(string brand, string model, int year, double price) 
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Brand} {this.Model}";
        }

        public string GetDetails()
        {
            return $" Car Brand: {this.Brand}\n Car Model: {this.Model}\n Car Year: {this.Year}\n Car Price: {this.Price} Euros";
        }
    }
}
