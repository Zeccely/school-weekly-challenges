using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Bakery
    {
        private string bname;
        private int VAT_PERCENTAGE = 9; //now tell me how is a percent an int ONLY 9???? WAKANDA DREAM WORLD IS THIS
        private List<Sandwich> sandwichList;

        public Bakery(string name )
        {
            this.bname = name;
            new Ingredient("Cucumber", 0.05);
            new Ingredient("Tomato", 0.15);
            new Ingredient("Cheddar", 0.2);
            new Ingredient("Ham", 0.15);
            new Ingredient("Chorizo", 0.25);
            new Ingredient("Apple", 0.1);
            new Ingredient("Tuna", 0.2);
            new Ingredient("Smoked Salmon", 0.4);
            new Ingredient("Cream cheese", 0.15);
            new Ingredient("Gouda cheese", 0.1);

        }

        public string GetName()
        {
            return bname;
        }

        public void AddSandwitch(Sandwich s)
        {
            sandwichList.Add(s);
        }

        public Dictionary<Ingredient, string, double > GetAvailableIngredients() //no arrays in this assignment.
        {
            return 
        }








    }
    
}
