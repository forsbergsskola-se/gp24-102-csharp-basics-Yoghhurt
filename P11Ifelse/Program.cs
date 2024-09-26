//P11_1 

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
//P11_4

Console.WriteLine("Need some help with maths?");

string numInput = Console.ReadLine();
double numOne = double.Parse(numInput);
string op = Console.ReadLine();
string numInput2 = Console.ReadLine();
double numTwo = double.Parse(numInput2);

double res = 0;

if (op == "+")
{
   res  = numOne + numTwo;
}

if (op == "-")
{
    res  = numOne - numTwo;
}

if (op == "*")
{
    res  = numOne * numTwo;
}

if (op == "/")
{
    res  = numOne / numTwo;
}
Console.WriteLine($"{res}");

//P11_5

Console.WriteLine("Is that number even or odd?");
string userInput3 = Console.ReadLine();
int userInt = int.Parse(userInput3);

if (userInt  % 2 == 0)
{
    Console.WriteLine($"{userInt} is even");
}
else
{
    Console.WriteLine($"{userInt} is odd");
}

//P11 main exercise

Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int userAge = int.Parse(ageInput);

if (userAge <= 12)
{
    Console.WriteLine("You're a child.");
}
if (userAge <= 19)
{
    Console.WriteLine("You're a teen.");
}
else
{
    Console.WriteLine("You're an Adult.");
}

Console.WriteLine("Give me another integer");
string intInput = Console.ReadLine();
int userInter = int.Parse(intInput);

if (userInter >= userAge)
{
    Console.WriteLine($"{userInter} is the highest number.");
    Console.WriteLine($"{userAge} is the lowest number.");
}
else
{
    Console.WriteLine($"{userAge} is the highest number.");
    Console.WriteLine($"{userInter} is the lowest number.");
}

if (userInter % 2 == 0)
{
    Console.WriteLine($"{userInter} is even");
}
else
{
    Console.WriteLine($"{userInter} is odd");
}

