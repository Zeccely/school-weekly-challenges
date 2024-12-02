using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaToppings
{
    internal class PizzaOrder
    {
        private double pPrice;
        private double toppingPrice;
        private List<Enum> toppers {  get; set; }


        public PizzaOrder(double price, double toppingPrice)
        {
            this.pPrice = price;
            this.toppingPrice = toppingPrice;
        }

        public enum Toppings
        {
            mushrooms,
            bell_pepper,
            tuna,
            pineapple,
            olives,
            ham,
            mozarella,
            anchovies,
            chicken,
            frikandel,
            krenten

        }
        public List<Enum> AddTopping(Enum topping)
        {
            toppers.Add(topping); 
            return toppers;
        }
        public List<Enum> RemoveTopping(Enum topping)
        {
            toppers.Remove(topping);
            return toppers;
        }

    }

   
}
