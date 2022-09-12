// int totalMinutes = 87;

// int hours = (int)(totalMinutes / 60);

// int minutes = totalMinutes % 60;

// Console.WriteLine("Hours " + hours);
// Console.WriteLine("Minutes " + minutes);
// Console.WriteLine(totalMinutes + " is equal to " + hours + " and " + minutes + " minutes.");

// int wholePart;
// double value1 = 12.5;
// double value2 = 2.0;
// // wholePart = (int)value1 / (int)value2;
// wholePart = (int)(value1 / value2);

//  constant key word dataType VARIABLE_NAME_ALL_CAPS assign Value
// const int DAYS_IN_A_WEEK = 7;

// Console.Write("Hello, what is your name? ");
// string name = Console.ReadLine();

// Console.WriteLine("Your name is {0}", name);
// Console.Write("Enter your favorite number: ");

// string favoriteNumberResponse = Console.ReadLine();
// //  this statement parses from String to Int
// int favoriteNumberConverted = int.Parse(favoriteNumberResponse);

// Console.WriteLine("Your favorite number is {0}", favoriteNumberConverted);

// Console.Write("Enter the price of your T-Shirt: ");

// // Console.ReadLine() will return a string, you must convert to double
// double shirtPrice = double.Parse(Console.ReadLine());

// Console.WriteLine("The Price of the Shirt is {0}", shirtPrice);

double firstScore = 0;

Console.Write("The first score is: ");
firstScore = double.Parse(Console.ReadLine());

double secondScore = 0;

Console.Write("The second score is: ");
secondScore = double.Parse(Console.ReadLine());

double average = (firstScore + secondScore) / 2;

Console.WriteLine("The average is: {0}", average);
