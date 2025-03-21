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
        switch (Size)
        {
            case Size.Small: return 1;
            case Size.Medium: return 3;
            case Size.Large: return 5;
        }
        return 0;
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


public enum Size { Small, Medium, Large }
public enum Diet { Carnivore, Herbivore }