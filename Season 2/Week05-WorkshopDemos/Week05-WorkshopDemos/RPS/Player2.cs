using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    internal class Player2
    {
        private Random rnd = new Random();

        public Choice PcChoice()
        {

            Choice choiceP2 = (Choice)rnd.Next(1, 4);
            //Console.WriteLine($"P2 chose {choiceP2}");
            return choiceP2;
        }
    }
}
