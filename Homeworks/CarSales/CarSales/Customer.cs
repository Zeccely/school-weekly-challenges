using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Customer
    {
        public string name { get; private set; }
        public string phoneNo { get; private set; }
        public string address { get; private set; }
        public string zipCodeCity { get; private set; }

        public Customer( string name, string phoneno, string address, string zipcodecity) 
        {
            this.name = name;
            this.phoneNo = phoneno;
            this.address = address;
            this.zipCodeCity = zipcodecity;
        }

     

        public override string ToString()
        {
            return $"{this.name} {this.phoneNo} {this.address} {this.zipCodeCity}";
        }

       
    }
}
