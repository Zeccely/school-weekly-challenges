﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    public class SnackBar
    {
        public Dictionary<string,Snack> snackDict = new Dictionary<string, Snack>();
        

        public SnackBar()
        {
           snackDict.Add("Snack1", new Snack("Loempia", 2, 20));
           snackDict.Add("Snack2", new Snack("Kaastengels", 5, 30));
           snackDict.Add ("Snack3", new Snack("Mexicano", 3, 35));
        }

        public double ProcessOrder(double snacc1, double snacc2, double snacc3)
            
        { //check first decrease later
            
            bool loempia = snackDict["Snack1"].CheckStock();
            bool kaastengel = snackDict["Snack2"].CheckStock();
            bool mexicano = snackDict["Snack3"].CheckStock();


            if (!loempia || !kaastengel || !mexicano)
            {
                MessageBox.Show("Cannot order");
               
            }
            else
            {
                MessageBox.Show("Items ordered successfulley");
                loempia = snackDict["Snack1"].DecreaseStock(snacc1);
                kaastengel = snackDict["Snack2"].DecreaseStock(snacc2);
                mexicano = snackDict["Snack3"].DecreaseStock(snacc3);
            }
            
            
            double soldloempia = 20 - snackDict["Snack1"].GetAmountStock();  
            double soldkaas = 30 - snackDict["Snack2"].GetAmountStock();
            double soldMexi = 35 - snackDict["Snack3"].GetAmountStock();


            double gottapay = (snacc1 * snackDict["Snack1"].GetPrice() + snacc2 * snackDict["Snack2"].GetPrice() + snacc3 * snackDict["Snack3"].GetPrice());
            return gottapay;
        }
           


    }

    
}
