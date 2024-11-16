List<double> numberList = new List<double> { };
var userNumber = true;

Console.WriteLine("Please Input Number");
while (userNumber)
{
    string userInput = Console.ReadLine();
    
    if (userInput == "$")
    {
        break;
    }
    else
    {
        var inputNumber = Convert.ToDouble(userInput);
        numberList.Add(inputNumber);
    }
}

Console.WriteLine(string.Join(",",numberList));

double avg = numberList.Average();
double highesNum = numberList.Max();
double lowestNum = numberList.Min();
double numberSum = numberList.Sum();

double result = 1;
double number = 1;
foreach (double n in numberList)
{
   
    result = result * n;
    
}
Console.WriteLine(result);
