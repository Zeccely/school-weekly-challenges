using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;


//using System.Linq; //fuck you
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    [DataContract]
    public class BreadShop
    {
        [DataMember]
        private string bname;
        [DataMember]
        private int VAT_PERCENTAGE = 9; //now tell me how is a percent an int ONLY 9???? WAKANDA DREAM WORLD IS THIS
        [DataMember]
        private List<Sandwich> sandwichList;
        [DataMember]
        private List<Ingredient> ingredientList;
        [DataMember]
        private List<Sandwich> soldSandwhichList;

        

        public BreadShop(string name )
        {
            this.bname = name;
            this.ingredientList = new List<Ingredient>()
            {
                new Ingredient("Cucumber", 0.05),
                new Ingredient("Tomato", 0.15),
                new Ingredient("Cheddar", 0.2) ,
                new Ingredient("Ham", 0.15) ,
                new Ingredient("Chorizo", 0.25) ,
                new Ingredient("Apple", 0.1),
                new Ingredient("Tuna", 0.2),
                new Ingredient("Smoked Salmon", 0.4) ,
                new Ingredient("Cream cheese", 0.15) ,
                new Ingredient("Gouda cheese", 0.1) 

            };

            this.sandwichList = new List<Sandwich>();
            this.soldSandwhichList = new List<Sandwich>();
            Debug.WriteLine(ingredientList.Count);
        }

        public string GetName()
        {
            return this.bname;
        }

        public void AddSandwitch(Sandwich sandwich)
        {
            Debug.WriteLine(string.Join(" ",sandwich));
            this.sandwichList.Add(sandwich);                          
            
        }
        public void RemoveSandwich(Sandwich sandwich) //experimental stuff don't mind me
        {
            if (sandwichList.Contains(sandwich) && sandwichList.Count > 0)
            {
                this.sandwichList?.Remove(sandwich);
            }
            else
            {
                MessageBox.Show("Couldn't remove, make sure the name is the same. If all else fails contact Jessica"); 
            }
        }
        public void SellSandwich(Sandwich sandwich)
        {
            if(sandwichList.Contains(sandwich))
            {
                sandwichList.Remove(sandwich);
                
                soldSandwhichList.Add(sandwich);
            }
            else
            {
                MessageBox.Show("Not a sandwich");
            }
        }

        public List<Ingredient> GetAvailableIngredients() //no arrays in this assignment.
        {
            return this.ingredientList;
        }

        public List<Sandwich> GetAvailableSandwiches()
        {
            return this.sandwichList;
        }
        
        public List<Sandwich> GetAvailableSandwiches(BreadType btype)
        {
            List<Sandwich> availableSandwiches = new List<Sandwich>();
            
            foreach (Sandwich y in this.sandwichList)
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
