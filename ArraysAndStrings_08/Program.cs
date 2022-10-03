// Create a string variable, to hold the sentence 'Hello World!'
string helloWorldString = "Hello World!";

//  This proves that each character in the string is in fact, a char data type 
char H = helloWorldString[0];
char e = helloWorldString[1];
char l = helloWorldString[2];
char l2 = helloWorldString[3];
char o1 = helloWorldString[4];
char space = helloWorldString[5];
char W = helloWorldString[6];
char o2 = helloWorldString[7];
char r = helloWorldString[8];
char l3 = helloWorldString[9];
char d = helloWorldString[10];
char exclamation = helloWorldString[11];

Console.WriteLine("The String: " + helloWorldString);
Console.WriteLine("The Chars : " + H + e + l + l2 + o1 + space + W + o2 + r + l3 + d + exclamation);

//  Print out the length of the string 
Console.WriteLine($"The length of the string 'helloWorld' is {helloWorldString.Length}");

//  Let's play around with string upper casing
Console.WriteLine($"Let's upper case the first 'o' in the 'helloWorld' string variable");
Console.WriteLine(helloWorldString[4].ToString().ToUpper());

//  Finally, now that you understand the basics concepts of String, which has an array
//  working in the background, let's create a real C# array object
char[] helloWorldArray = new char[12];
//  The above declaration and initialization means that we are creating an array of 'char'
//  that will hold 12 'char' data type character
helloWorldArray[0] = helloWorldString[0];
helloWorldArray[1] = helloWorldString[1];
helloWorldArray[2] = helloWorldString[2];
helloWorldArray[3] = helloWorldString[3];
helloWorldArray[4] = helloWorldString[4];
helloWorldArray[5] = helloWorldString[5];
helloWorldArray[6] = helloWorldString[6];
helloWorldArray[7] = helloWorldString[7];
helloWorldArray[8] = helloWorldString[8];
helloWorldArray[9] = helloWorldString[9];
helloWorldArray[10] = helloWorldString[10];
helloWorldArray[11] = helloWorldString[11];

//  Now let's Console Writeline the helloWorldArray
Console.WriteLine("The String: " + helloWorldString);
Console.WriteLine("The Array : " + helloWorldArray);    //  This will output System.Char[]
Console.WriteLine("The Array : " + new string(helloWorldArray));

//  We can also convert a string to an array of chars
char[] convertedHelloWorldString = helloWorldString.ToArray();

//  The below statements creates an array of 'double' data types, that can store
//  7 different double values
double[] myFavoriteDecimalNumbers = new double[7];
myFavoriteDecimalNumbers[0] = 3;
myFavoriteDecimalNumbers[1] = 6;
myFavoriteDecimalNumbers[2] = 2;
myFavoriteDecimalNumbers[3] = 4;
myFavoriteDecimalNumbers[4] = 31;
myFavoriteDecimalNumbers[5] = 128;
myFavoriteDecimalNumbers[6] = 6;

//  This should print out 12
double result = myFavoriteDecimalNumbers[1] + myFavoriteDecimalNumbers[6];
Console.WriteLine(result);

//  Keegan wants to know what happens if we CW the variable myFavoriteDecimalNumbers
Console.WriteLine(myFavoriteDecimalNumbers);    // No, it will show System.Double[]

//  On Wednesday we will learn loop  to extract all of the numbers from the array of Double

//  In Conclusion, you can have an array of anything you desire in the whole wide world.
string[] arrayOfString = new string[10];
int[] arrayOfInt = new int[10];

