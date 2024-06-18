// Implicitly typed variables
// 1. var is a keyword that tells the compiler to infer the type of the variable from the expression on the right side of the assignment operator.
// 2. The type of the variable is determined at compile time.
// 3. The type of the variable cannot be changed once it is assigned.
// 4. The type of the variable is determined by the type of the expression on the right side of the assignment operator.

var i = 10; // int
var s = "Hello"; // string
var d = 10.5; // double
var b = true; // bool


var myFavoriteGenre = "Rock"; // string
// myFavoriteGenre = 10; // Error: Cannot implicitly convert type 'int' to 'string'

var myFavoriteNumber = 10; // int
// myFavoriteNumber = 10.5; // Error: Cannot implicitly convert type 'double' to 'int'

var yourFavoriteNumber = 16; // int

// int ourFavoriteNumber = myFavoriteNumber + yourFavoriteNumber; // int (10 + 16 = 26) 
var ourFavoriteNumber = myFavoriteNumber + yourFavoriteNumber; // int (10 + 16 = 26), var is inferred as int
// str ourFavoriteNumber = myFavoriteNumber + yourFavoriteNumber; // Error: Cannot implicitly convert type 'int' to 'string'