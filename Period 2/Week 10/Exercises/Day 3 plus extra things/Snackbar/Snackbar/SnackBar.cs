using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    public class SnackBar
    {
        Snack snac1 = new Snack("Loempia", 2, 20);
        Snack snac2 = new Snack("Kaastengels", 5, 30);
        Snack snac3 = new Snack("Mexicano", 3, 35);
        public List<Snack> snackList;

        public double ProcessOrder(double snacc1, double snacc2, double snacc3)
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
                MessageBox.Show("Items ordered successfulley");
            }
           

            double gottapay = (snacc1 * snac1.GetPrice() + snacc2 * snac2.GetPrice() + snacc3 * snac3.GetPrice());
            return gottapay;
        }
        public void AddSnack(Snack snacky)
        {
            snackList.Add(snacky);
        }
     


    }

    
}
