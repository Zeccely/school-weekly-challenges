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
        private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };
        private List<int> numberGone = new List<int>();
        private Random RandomGenerator = new Random();
        

        public Lottery(int maxval, int nrlength) 
        {
            this.maxValue = maxval;
            this.nrLength = nrlength;
            
        }
        
        public List<int> DrawAllNumbers(int nrlength) 
        {

            List<int> DrawnNumbas = new();
            bool isitafraud;

            for (int index = 0; index < nrlength; index++)
            {
                
                //rename all funnies and use camelCase

                isitafraud = true;

                while (isitafraud)
                {
                    int randomNumba = RandomGenerator.Next(numbers.Length);
                    if (!numberGone.Contains(randomNumba))
                    {
                        isitafraud = false;
                        numberGone.Add(randomNumba);
                        DrawnNumbas.Add(randomNumba); 
                    }
                   
                }   

                
            }
            Debug.WriteLine(string.Join(" ",DrawnNumbas));
            return DrawnNumbas;
            
        }
         public bool IsLotteryFinished()
        {
            return true;
        }
        


    }
}

