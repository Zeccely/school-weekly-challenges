using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    internal class PlayerComputer: IPlayer
    {
        private Random rnd = new Random();

        public Choice MakeChoice()
        {
            Choice choiceP2 = (Choice)rnd.Next(1, 4);
            //Console.WriteLine($"P2 chose {choiceP2}");
            return choiceP2;
        }
    }
}
