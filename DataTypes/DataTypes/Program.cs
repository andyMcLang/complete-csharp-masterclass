// See https://aka.ms/new-console-template for more information

// implicitely typed variable

var myFavoriteGenre = "DramaComedy";

var myFavoriteNumber = 7;

// not working
// myFavoriteGenre = 65;

// Referency Type
// explicitely typed variable
string myName = "Denis";

// defining or setting up a variable
string petsName;

// initialize variable
petsName = "Daisy";

// Operators and Order of Evaluation
int num1 = 5;
int num2 = 13;

Console.WriteLine("Yhteenlasku num1 + num2 = " + (num1 + num2));
Console.WriteLine("Vähennyslasku num1 + num2 = " + (num1 - num2));
Console.WriteLine("Kertolasku num1 + num2 = " + (num1 * num2));
Console.WriteLine("Jakolasku num1 + num2 = " + (Convert.ToDouble(num1) / Convert.ToDouble(num2)));

Console.ReadLine();