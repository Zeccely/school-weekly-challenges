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
        public string Name { get; private set; }
        [DataMember]
        public string PhoneNo { get; private set; }
        [DataMember]
        public string Address { get; private set; }
        [DataMember]
        public string ZipCodeCity { get; private set; }
        public int ID  { get; private set; }

        public Customer( string name, string phoneno, string address, string zipcodecity) 
        {
            this.Name = name;
            this.PhoneNo = phoneno;
            this.Address = address;
            this.ZipCodeCity = zipcodecity;
 
        }
        public Customer(int id, string name, string phoneno, string address, string zipcodecity)
        {
            this.Name = name;
            this.PhoneNo = phoneno;
            this.Address = address;
            this.ZipCodeCity = zipcodecity;
            this.ID = id;

        }




        public override string ToString()
        {
            return $"{this.ID} {this.Name} ";
        }

        public void SetID(int id)
        {
            this.ID = id ;
        }
       
    }
}
