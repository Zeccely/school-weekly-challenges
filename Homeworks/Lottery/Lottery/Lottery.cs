using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Lottery
    {
        public int maxValue { get; private set; }
        private int nrLength;
        int[] numbas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };
        Random Randi = new Random();
        

        public Lottery(int maxval, int nrlength) 
        {
            this.maxValue = maxval;
            this.nrLength = nrlength;
            
        }
        
        public int[] DrawAllNumbers(int nrlength) 
        {
            
            int[] DrawnNumbas = new int[nrlength];

            for (int index = 0; index < nrlength; index++)
            {
                int randomNumba = Randi.Next(numbas.Length);
                DrawnNumbas[index] = numbas[randomNumba];
                
                
            }
            Debug.WriteLine(string.Join(" ",DrawnNumbas));
            return DrawnNumbas;
            
        }
        public int DrawNextNumba()
        {

        }


    }
}

