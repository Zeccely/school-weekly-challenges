using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CarSales
{
    [DataContract]
    public class Car
    {
        public int ID { get; private set; } 
        [DataMember]
        public string Brand {  get; private set; }
        [DataMember]
        public string Model { get; private set; }
        [DataMember]
        public int Year { get; private set; }
        [DataMember]
        public double Price { get; private set; }


        public Car(string brand, string model, int Year, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = Year;
            this.Price = price;
     
        }
        public Car(int Id, string brand, string model, int year, double price) 
        {
            this.ID = Id;
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

        public void SetID(int id)
        {
            this.ID = id;

        }


    
    }
}
