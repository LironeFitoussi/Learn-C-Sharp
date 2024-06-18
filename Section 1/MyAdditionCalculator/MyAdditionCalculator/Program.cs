
Console.WriteLine("Simple Addition Calculator");
Console.WriteLine("--------------------------");

// Text to prompt the user to enter the first number
Console.WriteLine("Enter the first number: ");

// Read the user input and store it in a variable
string userInput = Console.ReadLine();

// Convert the user input to an integer
int firstNumber = int.Parse(userInput);

// Text to prompt the user to enter the second number
Console.WriteLine("Enter the second number: ");

// Read the user input and store it in a variable
userInput = Console.ReadLine();

// Convert the user input to an integer
int secondNumber = int.Parse(userInput);

// Calculate the sum of the two numbers
int sum = firstNumber + secondNumber;

// Display the sum to the user
Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);

// Wait for the user to press a key before closing the console window
Console.ReadKey();