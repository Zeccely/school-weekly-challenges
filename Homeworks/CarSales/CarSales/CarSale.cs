﻿using System.Runtime.Serialization;

namespace CarSales
{
    [DataContract]
    public class CarSale
    {
        [DataMember]
        public Car Soldcar {  get; private set; }
        [DataMember]
        public Customer Customer { get; private set; }
        [DataMember]
        public DateTime DateOfPurchase { get; private set; }

        public CarSale(Car soldcar, Customer buyer, DateTime dateOfPurchase)
        {
            this.Soldcar = soldcar;
            this.Customer = buyer;
            this.DateOfPurchase = dateOfPurchase;
        }
        public string Markdowner()
        {
            return $" # {DateOfPurchase: dd MMMM yyyy} | {Soldcar.Brand} {Soldcar.Model} ({Soldcar.Year})\n\n - *Price*: {Soldcar.Price}\n - *Customer*: {Customer.name}\n - *Phone no.*: {Customer.phoneNo}\n - *Address*: {Customer.address}\n - *Zip code & city*: {Customer.zipCodeCity}\n\n---\n\n";
        }

        public override string ToString()
        {
            return $"{Customer} : {Soldcar.Brand} {Soldcar.Model}";
        }
    }
}
