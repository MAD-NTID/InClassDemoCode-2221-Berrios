//  Conditions using the AND operator &&

// //  if statements will execute only if they're true
// if(true)
// {
//     Console.WriteLine("Hello World, it's true");
// }
// else 
// {
//     Console.WriteLine("Nothing happened.");
// }

// int leftSide = 40;
// int rightSide = 33;

// if(leftSide < rightSide) 
// {
//     Console.WriteLine("Right side is greater " + rightSide);
// }
// else 
// {
//     Console.WriteLine("Left side is greater " + leftSide);
// }

//  Prompt the user for a number
// double userInput = 0;
// double numberToCompare = 55;

// Console.Write("Enter a number: ");
// userInput = double.Parse(Console.ReadLine());

// if(userInput >= numberToCompare) 
// {
//     Console.WriteLine("The user's input number is greater than {0}", numberToCompare);
// }
// else
// {
//     Console.WriteLine("The user's input number is less than {0}", numberToCompare);
// }

// /* This is a conditional block */
// if(userInput > numberToCompare) 
// {
//     Console.WriteLine("The user's input number is greater than {0}", numberToCompare);
// }
// else if(userInput < numberToCompare)
// {
//     Console.WriteLine("The user's input number is less than {0}", numberToCompare);
// }
// //  this last statement will execute if all above conditions are "false"
// else
// {
//     Console.WriteLine("The numbers are the same {0} and {1} ", userInput, numberToCompare);
// }
// /* Ends conditional block*/

// Console.Write("Enter your age: ");

// int age = int.Parse(Console.ReadLine());

// if(age < 21)
// {
//     Console.WriteLine("You ain't allowed to have a drink yet");
// }
// //  using a logical operator to set a range, this '&&' is known as AND
// else if(age >= 21 && age <= 65) 
// {
//     Console.WriteLine("You are allowed to have a sip");
// }
// else 
// {
//     Console.WriteLine("You should have stopped drinking already");
// }

//  Conditions using the OR operator ||

Console.Write("Enter a color: ");

//  Use the to lower method to lowercase the user's input
string colorInput = Console.ReadLine().ToLower();

if(colorInput == "red" || colorInput == "blue" || colorInput == "black" || colorInput == "orange") 
{
    Console.WriteLine("You belong to group #1");
}
else if(colorInput == "green" || colorInput == "purple")
{
    Console.WriteLine("You belong to group #2");
}
else
{
    Console.WriteLine("You don't belong in any group");
}