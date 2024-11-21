using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    public class Snack
    {
        private string name;// why not just {get, private set}
        private double price;
        private double amountStock;
        

        public Snack(string namez, double pricez, double amouties) 
        {
            this.name = namez;
            this.price = pricez;
            this.amountStock = amouties;
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
