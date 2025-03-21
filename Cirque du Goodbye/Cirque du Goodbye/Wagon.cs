using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cirque_du_Goodbye;

public class Wagon
{
    public List<Animal> Animals { get; set; } = new();
    public int MaxCapacity = 10;
    public int CurrentCapacity = 0;
    

    public bool IsValid(Animal a)
    {
        if (CurrentCapacity + a.Points() > MaxCapacity)
        {
            return false;
        }

        foreach (var animal in Animals)
        {
            foreach (var otheranimal in Animals)
            {
                if (animal != otheranimal && animal.CanEat(otheranimal))
                {
                    return false;
                }
            }
        }

        return true;
        //if (Animals.Sum(animal => animal.Points()) > 10)
        //{
        //    return false;
        //}
        //return true;

    }

    public bool TryAdd(Animal animal)
    {
        if (IsValid(animal))
        {
            Animals.Add(animal);
            CurrentCapacity += animal.Points();
            return true;
        }
        return false;
    }

    //public bool TryPlace(Animal animal)
    //{
    //    foreach (Animal otheranimal in Animals)
    //    {
    //        if (Animals.Contains(otheranimal))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    
    //}

    public override string? ToString()
    {
        return $"{CurrentCapacity} {string.Join(", ", Animals)}";
    }
}
