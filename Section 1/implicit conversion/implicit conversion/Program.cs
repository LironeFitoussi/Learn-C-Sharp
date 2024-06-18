// implicit conversion
// 1. Implicit conversion is done by the compiler.
// 2. It is safe and does not result in data loss.
// 3. It is also known as widening conversion.
// 4. It is done when the target type is larger than the source type.
// 5. It is done when the target type is smaller than the source type.


int myInt = 1323450983;
// Console.WriteLine(myInt);

double myDouble = myInt; // implicit conversion from int to double
// Console.WriteLine(myDouble);

long myLong = myInt; // implicit conversion from int to long
// Console.WriteLine(myLong);

myLong = 132345098312389013;
//myInt = myLong; // Error: Cannot implicitly convert type 'long' to 'int' because the target type is smaller than the source type.

float myFloat = 10.5f;
myDouble = myFloat; // implicit conversion from float to double

// Console.WriteLine(myFloat);

// explicit conversion
// 1. Explicit conversion is done by the programmer.
// 2. It is not safe and may result in data loss.
// 3. It is also known as narrowing conversion.
// 4. It is done when the target type is smaller than the source type.
// 5. It is done when the target type is larger than the source type.


int myInt3;
double myDouble3 = 13.5;
//myInt3 = myDouble3; // Error: Cannot implicitly convert type 'double' to 'int' because the target type is smaller than the source type.
myInt3 = (int)myDouble3; // explicit conversion from double to int
Console.WriteLine(myInt3);

// int myInt2 = myDouble; // Error: Cannot implicitly convert type 'double' to 'int' because the target type is smaller than the source type.
int myInt2 = (int)myLong; // explicit conversion from double to int) // explicit conversion from long to int might result in data los
Console.WriteLine(myInt2);

float myFloat2 = 123.123f;
myDouble = 13.2123123123;

myFloat2 = (float)myDouble; // explicit conversion from double to float

Console.WriteLine(myFloat2);
Console.WriteLine("Click any key to exit...");
Console.ReadKey();
