using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class PlayerHuman: IPlayer
    {
        public Choice MakeChoice()
        {
            int input;
            do
            {
                Console.WriteLine("Enter choice: Rock (1), Paper (2), Scissors (3)");
                input = Console.ReadKey(true).KeyChar;
            } while (input < '1' || input > '3');
            Choice choiceP1 = (Choice)(input);
            //Console.WriteLine($"P1 chose {choiceP1}");
            return choiceP1;
        }


    }
    
}
