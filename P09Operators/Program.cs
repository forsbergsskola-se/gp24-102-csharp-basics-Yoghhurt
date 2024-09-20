//P09
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

//P09_1
Console.WriteLine("How fast are you going?");

string userInput2 = Console.ReadLine();

int kmh = int.Parse(userInput2);

double ms = kmh / 3.6;

Console.WriteLine($"You're going {ms} m/s");
//P09_2
Console.WriteLine("Give me some minutes!");

string userInput3 = Console.ReadLine();

int minute = int.Parse(userInput3);

int seconds2 = minute * 60; 
Console.WriteLine($"That's {seconds2} in seconds");

//P09_3
Console.WriteLine("Give me some numbers");
string inputinput = Console.ReadLine();
float number = float.Parse(inputinput);
string inputinput2 = Console.ReadLine();
float number2 = float.Parse(inputinput2);

float result2 = number / number2;

Console.WriteLine($"{result2}");



//P09_4
Console.WriteLine("Need any thing figured out?");

string userInput4 = Console.ReadLine();

int divide = int.Parse(userInput4);

string userInput5 = Console.ReadLine();

int divide2 = int.Parse(userInput5);

float divide3 = divide / divide2; 

Console.WriteLine($"{divide3}");

//p09_5
Console.WriteLine("What's the radius of this circle?");
string userInput6 = Console.ReadLine();

int radius = int.Parse(userInput6);

double area = radius * radius * 3.14;
Console.WriteLine($"That means the area is {area}");

//p09_6



//p09_7
Console.WriteLine("Let's multiply!");
string userInput7 = Console.ReadLine();
int multiply = int.Parse(userInput7);
string userInput8 = Console.ReadLine();
int multiply2 = int.Parse(userInput8);

int result3 = multiply * multiply2;
Console.WriteLine($"{result3}");

//p09_8
Console.WriteLine("How tall are you?");
string userInput9 = Console.ReadLine();
float tall = float.Parse(userInput9);
Console.WriteLine("How much do you weigh?");
string userInput10 = Console.ReadLine();
float weight = float.Parse(userInput10);

float reslut4 = tall * tall;
float reslut5 = weight / reslut4;

Console.WriteLine($"Your BMI is {reslut5}%");







 