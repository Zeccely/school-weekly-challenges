using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    internal class SnackBar
    {
        Snack snac1 = new Snack("Loempia", 2, 20);
        Snack snac2 = new Snack("Kaastengels", 5, 30);
        Snack snac3 = new Snack("Mexicano", 3, 35);
        private List<Snack> snackList;


        public void ProcessOrder(double snacc1, double snacc2, double snacc3)
        {
            bool loempia = snac1.DecreaseStock(snacc1);
            bool kaastengel = snac2.DecreaseStock(snacc2);
            bool mexicano = snac3.DecreaseStock(snacc3);

            if (loempia == false || kaastengel == false || mexicano== false)
            {
                MessageBox.Show("Cannot order");
            }
            else
            {
                MessageBox.Show("Item ordered successfulley");
            }
        }
        private List<Snack> AddSnacc()
        {
            snackList.Add(snac1);
        }
        public double GetRevenue()
        {
           
           return revenue
        }


    }

    
}
