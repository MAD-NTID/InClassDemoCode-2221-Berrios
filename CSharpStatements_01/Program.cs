Console.WriteLine("This is the first InClass Demo");

//  This is a single line comment starts with two forward slash

/* This is a block comment which allows multi-line
commenting
and this will still be a 
comment. Must start with forward slash and asterisk, and end
with asterisk and forward slash
*/

//  an integer variable with a whole number, can't have decimal
int wholeNumber = 25;   //good
//int wholeNumber2 = 25.5 //bad

string sentence = "You can write a whole sentence in a string object and you can show this in a terminal as output";

//  and unsigned integer doesn't have a symbol + in front of it, because it's already positive

//  a signed integer has a - (negative) sign in front of it indicating that's not a positive value

//  Example
// -4096 is a signed int (see the negative?)
//  4096 is an unsigned int (negative sign is gone)

/*
This is a string with multiple lines 
Hello
My name is
Michael
Berrios
*/
string multiLineString = "This is a string with multiple lines \nHello \nMy name is \nMichael \nBerrios";

Console.WriteLine(multiLineString);
Console.WriteLine();

//  Let's get the current year by using DateTime
int age = 18;
int thisYear = DateTime.Now.Year;
int yearBorn = thisYear - age;
int month = DateTime.Now.Month;

Console.WriteLine("Age: " + age);
Console.WriteLine("Current Year: " + thisYear);
Console.WriteLine("You were born in " + yearBorn + " in the month " + month);
Console.WriteLine();
Console.WriteLine("You were born in {0} in the month {1}", yearBorn, month);
Console.WriteLine();
Console.WriteLine($"You were born in {yearBorn} in the month {month}");

//  This is not allowed, string is not an int
//int myAge = "Michael";
