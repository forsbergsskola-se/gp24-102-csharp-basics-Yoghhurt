﻿//P11_1 

using System.ComponentModel.Design;

Console.WriteLine("Let's check your grade");

string result = Console.ReadLine();

int result2 = int.Parse(result);

if (result2 >= 90)
{Console.WriteLine("Your grade is: A");
    
}

if (result2 >= 80 && result2 < 90)
{Console.WriteLine("Your grade is: B");
    
}

if (result2 >= 70 && result2 < 80)
{Console.WriteLine("Your grade is: C");
    
}

if (result2 >=60 && result2 < 70)
{Console.WriteLine("Your grade is: D");
    
}
else if (result2 < 60)
{
    Console.WriteLine("Your grade is: F");
}

//P11_2
Console.WriteLine("Give me three numbers.");
string number1 = Console.ReadLine();
int num4 = int.Parse(number1);
string number2 = Console.ReadLine();
int num5 = int.Parse(number2);
string number3 = Console.ReadLine();
int num6 = int.Parse(number3);

int a = num4;
int b = num5;
int c = num6;
int min, max;

if (a > b & a > c)
{
    max = a;
}
else if (b > a & b > c)
{
    max = b;
}
else
{
    max = c;
}

if (a < b & a < c)
{
    min = a;
}
else if (b < a & b < c)
{
    min = b;
}
else
{
    min = c;
}

Console.WriteLine($"{max} is the biggest number.");
Console.WriteLine($"{min} is the smallest number.");

//P11_3
Console.WriteLine("Vowel, number or consonant?");
string userInput = Console.ReadLine();

List<char> numbers = new List<char>();
List<char> consonants = new List<char>();
List<char> vowels = new List<char>();

foreach (char check in userInput)
{
    if (char.IsDigit(check))
    {
        numbers.Add(check);
        Console.WriteLine("That is a digit");
    }
    else if ("AEIOUaeiou".IndexOf(check) >= 0)
    {
        vowels.Add(check);
        Console.WriteLine("That is a vowel");
    }
    else if (char.IsLetter(check))
    {
        consonants.Add(check);
        Console.WriteLine("That is a consonant");
    }
}






