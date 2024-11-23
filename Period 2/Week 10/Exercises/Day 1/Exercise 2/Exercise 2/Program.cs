using System.Linq.Expressions;

Console.WriteLine("Input a Number: ");
double number = Convert.ToDouble(Console.ReadLine());

try
{
if (number % 2 == 0)
{
    Console.WriteLine("This number is an even number");
}
else
{
    Console.WriteLine("This number is an odd number");
}
}
catch
{
    Console.WriteLine("This is not a number");
}




