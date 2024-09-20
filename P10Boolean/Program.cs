Console.WriteLine("What is your age?");

int age = int.Parse(Console.ReadLine());

if (age < 13) { 
    Console.WriteLine("You're a child.");
}else if (age < 18) { 
    Console.WriteLine("You're a teenager.");
} else { 
    Console.WriteLine("You're an adult.");
}