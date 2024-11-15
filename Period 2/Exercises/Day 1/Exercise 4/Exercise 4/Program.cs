List<double> numberList = new List<double> { };
var userNumber = true;

Console.WriteLine("Please Input Number");
while (userNumber)
{
    double inputtedNumber = Convert.ToDouble(Console.ReadLine());
    numberList.Add(inputtedNumber);
    if (inputtedNumber = " ")
    {
        break;
    }
      
}



