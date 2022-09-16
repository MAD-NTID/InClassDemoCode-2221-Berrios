Console.Write("What is your age? ");

//  this will force parse to a int variable
//  However, if a non-numerical input is parsed for int, program will crash
// int age = int.Parse(Console.ReadLine());

//  What does tryParse actually returns?
// int convertedNumber = 0;
// Console.WriteLine(int.TryParse("five", out convertedNumber));

// Console.WriteLine($"The parsed number is {convertedNumber}");

int age = 0;
bool validAge = int.TryParse(Console.ReadLine(), out age);

if(validAge && age > 20) 
{
    Console.WriteLine("You are allowed to drink");
}
else if(validAge && age <= 20)
{
    Console.WriteLine("You are not allowed to drink");
}
else 
{
    Console.WriteLine("Sorry, that's an invalid input, it must be a whole positive number.");
}

Console.WriteLine();

Console.Write("Enter your current bank balance: ");

double bankBalance = 0;
bool validBankBalance = double.TryParse(Console.ReadLine(), out bankBalance);

if(validBankBalance && bankBalance > 0 && bankBalance < 1000000)
{
    Console.WriteLine("You have some money");
}
else if(validBankBalance && bankBalance >= 1000000)
{
    Console.WriteLine("You are filthy rich");
}
else
{
    Console.WriteLine("You are either broke, or you input a bad value");
}