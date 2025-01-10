using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string name { get; private set; }
        [DataMember]
        public string phoneNo { get; private set; }
        [DataMember]
        public string address { get; private set; }
        [DataMember]
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
