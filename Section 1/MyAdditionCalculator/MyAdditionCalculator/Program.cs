using System.Globalization;

Console.WriteLine("Simple Addition Calculator");
Console.WriteLine("--------------------------");

double firstNumber;
double secondNumber;

// Text to prompt the user to enter the first number
Console.WriteLine("Enter the first number: ");

// Read the user input and store it in a variable
string userInput = Console.ReadLine();

// Convert the user input to an integer
/// <summary>
/// This variable stores the first number entered by the user.
/// </summary>
firstNumber = double.Parse(userInput, CultureInfo.InvariantCulture);


// Text to prompt the user to enter the second number
Console.WriteLine("Enter the second number: ");

// Read the user input and store it in a variable
userInput = Console.ReadLine();

// Convert the user input to an integer
secondNumber = double.Parse(userInput, CultureInfo.InvariantCulture);

// Calculate the sum of the two numbers
double sum = firstNumber + secondNumber;
sum = Math.Round(sum, 2);
// Display the sum to the user
// Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);

// Display a message to the user using string interpolation
Console.WriteLine($"The sum of {firstNumber.ToString(CultureInfo.InvariantCulture)} and {secondNumber.ToString(CultureInfo.InvariantCulture)} is: {sum.ToString(CultureInfo.InvariantCulture)}");
// Wait for the user to press a key before closing the console window
Console.WriteLine("Press any key to exit...");
Console.ReadKey();