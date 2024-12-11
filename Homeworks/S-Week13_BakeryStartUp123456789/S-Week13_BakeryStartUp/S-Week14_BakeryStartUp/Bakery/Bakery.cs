using System;
using System.Collections.Generic;
using System.Diagnostics;

//using System.Linq; //fuck you
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Bakery
    {
        private string bname;
        private int VAT_PERCENTAGE = 9; //now tell me how is a percent an int ONLY 9???? WAKANDA DREAM WORLD IS THIS
        private List<Sandwich> sandwichList;
        private Dictionary<string,Ingredient> ingredientDict;

        public Bakery(string name )
        {
            this.bname = name;
            ingredientDict = new Dictionary<string, Ingredient>()
            {
                { "Cucumber", new Ingredient("Cucumber", 0.05)},
                { "Tomato", new Ingredient("Tomato", 0.15) },
                { "Cheddar", new Ingredient("Cheddar", 0.2) },
                { "Ham", new Ingredient("Ham", 0.15) },
                { "Chorizo", new Ingredient("Chorizo", 0.25) },
                { "Apple", new Ingredient("Apple", 0.1) },
                { "Tuna", new Ingredient("Tuna", 0.2) },
                { "Smoked Salmon", new Ingredient("Smoked Salmon", 0.4) },
                { "Cream Cheese", new Ingredient("Cream cheese", 0.15) },
                { "Gouda Cheese",new Ingredient("Gouda cheese", 0.1) }

            };
            sandwichList = new List<Sandwich>();
          

        }

        public string GetName()
        {
            return bname;
        }

        public void AddSandwitch(Sandwich sandwich)
        {
            Debug.WriteLine(string.Join(" ",sandwich));
            sandwichList.Add(sandwich);                          //returns null
            
        }

        public Dictionary< string,  Ingredient > GetAvailableIngredients() //no arrays in this assignment.
        {
            return ingredientDict;
        }

        public List<Sandwich> GetAvailableSandwiches()
        {
            return sandwichList;
        }
        
        public List<Sandwich> GetAvailableSandwiches(BreadType btype)
        {
            List<Sandwich> availableSandwiches = new List<Sandwich>();
            
            foreach (Sandwich y in sandwichList)
            {
                
                if (y.GetBread() == btype)
                {
                    availableSandwiches.Add(y);
                }

            }
           
            return availableSandwiches;
        }







    }
    
}
