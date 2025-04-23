// implicit conversion

int myInt = 1323450983;
double myDouble = myInt;

long myLong = myInt;
myLong = 132345098312389013;

// explicit conversion
int myInt2 = (int)myLong;

float myFloat = 123.144f;
myDouble = 13.2123123123;

// explicit conversion
myFloat = (float)myDouble;

int myInt3;
double myDouble3 = 13.5;
myInt3 = (int)myDouble3;


Console.WriteLine("My Float: " + myFloat + " and My Double: " + myDouble);
Console.WriteLine("My Int3: " + myInt3 + " and My Double3: " + myDouble3);

// Conversion Helpers Parse and Convert

string myString = "123";
int myInt4 = int.Parse(myString);
Console.WriteLine("myString: " + myString + " and myInt4: " + myInt4);

string myString2 = "false";
bool myBoolean = Convert.ToBoolean(myString2);
Console.WriteLine("myString2: "+myString2 + " and myBoolean:" + myBoolean);


Console.ReadKey();