
using System.ComponentModel;
using Microsoft.Azure.Devices.Common;

Console.WriteLine("Please Input the number of people: ");

int numberOfPeople = int.Parse(Console.ReadLine());

string[] people = new string[numberOfPeople];

string nameOfPerson;

string ageOfPerson;

for (int index = 0; index < numberOfPeople; index=index+1 )
{
    Console.WriteLine("Insert Name: ");
    nameOfPerson = Console.ReadLine();
    Console.WriteLine("Insert Age: ");
    ageOfPerson = Console.ReadLine();

    string potato = nameOfPerson + " (" + ageOfPerson + "year(s) old)";
    people[index] = potato;
    
}

//Console.WriteLine(nameOfPerson + "(" + ageOfPerson + "year(s) old)");

Console.WriteLine(string.Join("\n", people)); //Joe (23 year(s) old) 


