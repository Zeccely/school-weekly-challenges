using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Sandwich
    {

        private string sname;
        private double basePrice;
        private BreadType sBreadType;
        private List<Ingredient> singredients;

        public Sandwich(string name, double price, BreadType breadtype )
        {
            
            this.sname = name;
            this.basePrice = price;
            this.sBreadType = breadtype;
        }

        public string GetName()
        {
            return sname;
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

        public string GetInfo()
        {
            return $"{sname}: ({string.Join(" ",sBreadType)} with {string.Join(" ",singredients)}";
        }

        public double GetPrice()
        {
            double pricetracker = 0;
            foreach( Ingredient y in singredients )
            {
                pricetracker += y.GetIngredientPrice();
            }
            return basePrice + pricetracker;
        }

        
    }
}
