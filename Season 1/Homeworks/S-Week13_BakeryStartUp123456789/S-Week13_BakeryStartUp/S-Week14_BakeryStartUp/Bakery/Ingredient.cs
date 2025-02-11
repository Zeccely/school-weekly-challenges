using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [DataContract]
    public class Ingredient
    {
        [DataMember]
        private string name;
        [DataMember]
        private double price;

        public Ingredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }
        
        public double GetPrice()
        {
            return price;
        }

        public override string ToString()   //friend and chatgpt told me this fixes the bakery.ingredient issue now I don't need extra loops or to use  ToString to get the values to show
        {
            return $"{this.name} {this.price}";
        }








    }
}
