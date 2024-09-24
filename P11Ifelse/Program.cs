//P11_1 
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


//P11_3
Console.WriteLine("Is that a vowel?");

char input = Console.ReadLine()[0];

if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' ||
              input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
{
    Console.WriteLine($"{input} is a vowel.");
}

else
{
    Console.WriteLine($"{input} is not a vowel.");
}





