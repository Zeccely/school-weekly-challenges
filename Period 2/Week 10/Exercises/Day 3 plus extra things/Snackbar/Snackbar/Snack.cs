using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    public class Snack
    {
        private string name;         // why not just {get, private set}
        private double price;
        private double amountStock;
        

        public Snack(string name, double price, double amount) 
        {
            this.name = name;
            this.price = price;
            this.amountStock = amount;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public double GetAmountStock()
        {
            return this.amountStock;
        }
        public bool DecreaseStock (double amount)
        {
            if (this.amountStock <= 0)
            {
                return false;
            }
            else
            {
                this.amountStock = this.amountStock - amount;
                return true;
            }
        }
    }
}
