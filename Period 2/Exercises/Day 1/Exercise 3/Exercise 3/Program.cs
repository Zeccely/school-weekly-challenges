double result;
Console.WriteLine("Please insert base number: ");
double basenumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please insert multiplier: ");
double multiplier = Convert.ToDouble(Console.ReadLine());

for (double i = 0; i <= multiplier; i = i + 1)
{
    result = (basenumber * i);

    Console.WriteLine(i + "*" + basenumber + "=" + result); 
}