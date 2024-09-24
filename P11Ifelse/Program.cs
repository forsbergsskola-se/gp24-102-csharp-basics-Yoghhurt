//P11_1 

using System.ComponentModel.Design;

Console.WriteLine("Let's check your grade");

string result = Console.ReadLine();

int result2 = int.Parse(result);

if (result2 >= 90)
{Console.WriteLine("Your grade is: A");
    
}

if (result2 >= 80)
{Console.WriteLine("Your grade is: B");
    
}

if (result2 >= 70)
{Console.WriteLine("Your grade is: C");
    
}

if (result2 <=60)
{Console.WriteLine("Your grade is: D");
    
}
else
{
    Console.WriteLine("Your grade is: F");
}

//P11_2
Console.WriteLine("Give me three numbers.");
string number1 = Console.ReadLine();
int number4 = int.Parse(number1);
string number2 = Console.ReadLine();
int number5 = int.Parse(number2);
string number3 = Console.ReadLine();
int number6 = int.Parse(number3);

int big, small;


//P11_3
Console.WriteLine("Is that a vowel?");

char input = Console.ReadLine()[0];

if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' ||
              input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
{
    Console.WriteLine($"{input} is a vowel.");
}

if (input != 'a' || input != 'e' || input != 'i' || input != 'o' || input != 'u' ||
    input != 'A' || input != 'E' || input != 'I' || input != 'O' || input != 'U')
{
    Console.WriteLine($"{input} is not a vowel.");
}

else
{
    Console.WriteLine($"{input} is a digit.");
}




