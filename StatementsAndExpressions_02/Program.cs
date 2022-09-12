//  you can create multiple variables of the same data type by separating variable names with comma
int y = 3, z = 5;

//  y gets overwritten by the new value 5
z = y = 5;

Console.WriteLine($"z Should be 5 z variable => {z}");
Console.WriteLine($"y Should be 5 y variable => {y}");
Console.WriteLine();

//  What is the remainder of 3 divided by 2 | use the modulo operator (%) to get remainder
Console.WriteLine("What is the remainder of 3 divided by 2?\n " +
$"The answer should be 1 => {3 % 2}");
Console.WriteLine();

y = 5;
z = 11;
double yzResult = z / y; // bigger number first
Console.WriteLine($"The result should be 2.2 if you divide 11 by 5 but we get => {yzResult}");
Console.WriteLine();

double yDouble = 5, zDouble = 11;
double yzResultDouble = zDouble / yDouble;
Console.WriteLine($"The result should be 2.2 if you divide 11 by 5, and we get => {yzResultDouble}");
Console.WriteLine();

//  int i = 10
//  long k = i * 3 + 4
//  double d = i * 3.1 + k / 2
int i = 10;
//  this is implicit conversion (int to long)
long k = i * 3 + 4;
//  this is explicit conversion (double to float)
float d = (float)(i * 3.1 + k / 2);

Console.WriteLine($"The answer for d is {d}");

//  Can we do it in reverse?
//long i = 10;
//  implicit conversion fails
//int k = i * 3 + 4;
//  this is explicit conversion (double to float)
//float d = (float)(i * 3.1 + k / 2);