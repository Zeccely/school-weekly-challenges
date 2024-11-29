using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Lottery
    {
        public int maxValue;
        public int nrLength;
        public Array numbas = new Array[100];
        

        public Lottery(int maxval, int nrlength) 
        {
            this.maxValue = maxval;
            this.nrLength = nrlength;
        }
        public int DrawAllNumbers(int nrlength) 
        {
            foreach (int i in numbas)
            {
                Array drawnnumber = new Array[i];
            }
            
        }

    }
}

