Console.WriteLine("Give me a number of seconds");
string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int numberOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numberOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;

Console.WriteLine("Number of days " + numberOfDays);
Console.WriteLine("Number of hours " + numberOfHours);
Console.WriteLine("Number of minutes " + numberOfMinutes);
Console.WriteLine("Number of seconds " + numberOfSeconds);

Console.WriteLine($"{numberOfDays}.{numberOfHours}:{numberOfMinutes}:{numberOfSeconds}");

Console.WriteLine($"In total that is {(float)seconds / 86400} days.");

Console.WriteLine("How fast are you going?");

string userInput2 = Console.ReadLine();

int kmh = int.Parse(userInput2);

double ms = kmh / 3.6;

Console.WriteLine($"You're going {ms} m/s");



 