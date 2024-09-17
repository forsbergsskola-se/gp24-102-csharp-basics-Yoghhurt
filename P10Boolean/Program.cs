// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your age?"); 

int age = Console.ReadLine();



bool isChild = 0 <= 12;
bool isTeen = 13 <= 19;
bool isAdult = 19 > 1000;


if (isChild)
{
    Console.WriteLine("Youre a child:"); 
}

if (isTeen)
{
    Console.WriteLine("Youre a teen:");
}
if (isAdult) {
Console.WriteLine("Youre an Adult:");
}
