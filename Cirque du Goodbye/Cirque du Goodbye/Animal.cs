using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirque_du_Goodbye;

public class Animal
{
    public Size Size { get; set; }
    public Diet Diet { get; set; }

    public Animal(Size size, Diet diet)
    {
        Size = size;
        Diet = diet;
    }

    public int Points()
    {

        return (int)Size;
    }

    public bool CanEat(Animal otheranimal)
    {
        if (this.Diet == Diet.Carnivore)
        {
            if (this.Points() >= otheranimal.Points())
            {
                return true;
            }
        }
        return false;
    }

    public override string? ToString()
    {
        return $"{Diet} , {Size}";
    }
}


public enum Size { Small=1, Medium=3, Large=5,XL=7 }
public enum Diet { Carnivore, Herbivore }