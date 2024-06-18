// Convertion Helpers Parse and Convert
string numberString = "123";
int result = int.Parse(numberString);
Console.WriteLine(result);

string myBooleanString = "true";
int myBooleanInt = 1;
bool myBool = Convert.ToBoolean(myBooleanString);
bool myBool2 = Convert.ToBoolean(myBooleanInt);
Console.WriteLine(myBool);
Console.WriteLine(myBool2);
// Console.WriteLine($"My Bool is: {myBool}");

Console.ReadKey();