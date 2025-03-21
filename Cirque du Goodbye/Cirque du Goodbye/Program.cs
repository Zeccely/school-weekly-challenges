// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Runtime.InteropServices;
using Cirque_du_Goodbye;

Console.WriteLine("Hello, World!");

List<Animal> AllAnimals = new() 
{
    new Animal(Size.Medium, Diet.Herbivore),
    new Animal(Size.Large, Diet.Carnivore),
    new Animal(Size.Medium, Diet.Carnivore),
    new Animal(Size.Small, Diet.Herbivore),
    new Animal(Size.Medium, Diet.Carnivore),
    new Animal(Size.Medium, Diet.Herbivore),
    new Animal(Size.Small, Diet.Carnivore),
    new Animal(Size.Large, Diet.Herbivore),
    new Animal(Size.Medium, Diet.Carnivore),
    new Animal(Size.Large, Diet.Herbivore),
    new Animal(Size.Large, Diet.Carnivore),


};

//AllAnimals = AllAnimals.OrderBy(a => Random.Shared.Next()).ToList();

List<Wagon> Wagons = new();

foreach (Animal a in AllAnimals)
{
    bool placed = false;
    foreach (Wagon wagon in Wagons)
    {
        
        if (wagon.TryAdd(a)) //tryadd checks if its valid
        {
            
            placed = true;
        }

    }
    if (!placed)
    {
        Wagon wagony = new Wagon();
        wagony.TryAdd(a);
        Wagons.Add(wagony);
    }




}
foreach (Wagon wagon in Wagons)
{
    Console.WriteLine(wagon);
}


Wagon Wagon1 = new Wagon();
Animal Lion = new Animal(Size.Medium, Diet.Carnivore);
Animal Giraffe = new Animal(Size.Large, Diet.Herbivore);
Animal Goat = new Animal(Size.Small, Diet.Herbivore);

if (Wagon1.TryAdd(Lion))
{
    Console.WriteLine("This is good");
}
else
{
    Console.WriteLine("This is bad");
}

if (Wagon1.TryAdd(Goat))
{
    Console.WriteLine("This is good");
}
else
{
    Console.WriteLine("This is bad");

}
Console.WriteLine(Wagon1);










