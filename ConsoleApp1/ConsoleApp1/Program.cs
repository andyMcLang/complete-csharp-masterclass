// implicit conversion

int myInt = 13;
double myDouble = myInt;

long myLong = 12;
// not working:
// myInt = myLong;

float myFloat = 13.4f;
myDouble = myFloat;

Console.WriteLine("My Float:" + myFloat + " and My Double:" + myDouble);

Console.ReadKey();