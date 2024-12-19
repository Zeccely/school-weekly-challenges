using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private BreadType breadType;
        [DataMember]
        private List<Ingredient> singredients;


        public Sandwich(string name, double price, BreadType breadtype )
        {
            
            this.sname = name;
            this.basePrice = price;
            this.breadType = breadtype;
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
            return breadType;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if ( this.singredients.Count < 5)
            {
                this.singredients.Add(ingredient);
            }
            else
            {
                MessageBox.Show("No more than 5");
            }
            
        }

        public override string ToString()
        {
            return $"{sname}: {string.Join(" ", breadType)} with {string.Join(" ", singredients)}";
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
