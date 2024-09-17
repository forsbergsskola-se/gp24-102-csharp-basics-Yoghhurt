// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me a number.");

string input = Console.ReadLine();
float numberOne = float.Parse(input);

Console.WriteLine(numberOne);

int numberTwo = (int)numberOne;
string finalNumber = numberTwo.ToString();

Console.WriteLine(finalNumber);
