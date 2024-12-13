using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [DataContract]
    public class Sandwich
    {
        [DataMember]
        private string sname;
        [DataMember]
        private double basePrice;
        [DataMember]
        private BreadType sBreadType;
        [DataMember]
        private List<Ingredient> singredients;


        public Sandwich(string name, double price, BreadType breadtype )
        {
            
            this.sname = name;
            this.basePrice = price;
            this.sBreadType = breadtype;
        }
        public Sandwich(string sname, double basePrice, BreadType sBreadType, List<Ingredient> singredients) 
            : this(sname, basePrice, sBreadType)
        {
            this.singredients = singredients;
        }

        public string GetName()
        {
            return this.sname;
        }

        public BreadType GetBread()
        {
            return sBreadType;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if ( this.singredients.Count < 5)
            {
                this.singredients.Add(ingredient);
            }
            
        }

        public override string ToString()
        {
            return $"{sname}: {string.Join(" ", sBreadType)}"; //with {string.Join(" ", singredients)}"; //I cannot add things without ingredients because of this
        }

        public double GetRevenue()
        {
            double pricetracker = 0;
            foreach( Ingredient y in singredients )
            {
                pricetracker += y.GetPrice();
            }
            return basePrice + pricetracker;
        }

        
    }
}
