//  Cooperative
/*
    GOAL: Create a program that prompts the user for 3 inputs and display in a nicely formatted
    output.

    Prompts:
        What is your full name?
        What is your major?
        What is your dream salary?

    Inputs:
        Full Name
        Major
        Expected Future Income

    Expectations:
        Set a Console Title
        Set a Console Background color and Foreground color (must contrast)
*/

Console.Title = "The Title of the Terminal Window";

//  background color
Console.BackgroundColor = ConsoleColor.Blue;

//  text color (aka. foreground)
Console.ForegroundColor = ConsoleColor.Black;

Console.Write("What is your full name? ");
string name = Console.ReadLine();

Console.Write("What is your major? ");
string major = Console.ReadLine();

Console.Write("What is your dream salary? ");
double salary = double.Parse(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine("Your name is {0}.\nYour major is {1}.\nYour dream salary is {2:C}.", name, major, salary);

//  Resets the background and foreground colors set earlier for the next session
Console.ResetColor();