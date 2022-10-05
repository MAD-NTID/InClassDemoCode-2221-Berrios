// Create a string variable, to hold the sentence 'Hello World!'
string helloWorldString = "Hello World!";

// //  This proves that each character in the string is in fact, a char data type 
// char H = helloWorldString[0];
// char e = helloWorldString[1];
// char l = helloWorldString[2];
// char l2 = helloWorldString[3];
// char o1 = helloWorldString[4];
// char space = helloWorldString[5];
// char W = helloWorldString[6];
// char o2 = helloWorldString[7];
// char r = helloWorldString[8];
// char l3 = helloWorldString[9];
// char d = helloWorldString[10];
// char exclamation = helloWorldString[11];

// Console.WriteLine("The String: " + helloWorldString);
// Console.WriteLine("The Chars : " + H + e + l + l2 + o1 + space + W + o2 + r + l3 + d + exclamation);

char[] helloWorldChars = new char[helloWorldString.Length];

//  i < helloWorldString.Length
//  i <= helloWorldString.Length - 1

for(int i = 0; i != helloWorldString.Length; i++)
{
    //  gets the index position in the string object, and assign it to the char array object in given position of i
    helloWorldChars[i] = helloWorldString[i];
}

//  Test that we actually got each of the characters in the helloWorldString string by looping the helloWorldChars array
for(int i = 0; i < helloWorldChars.Length; i++)
{
    Console.Write(helloWorldChars[i]);
}

Console.WriteLine();

//  We can force the loop by manually putting true bool in the while test condition, and then break it with
//  a test somewhere in the if statements
// while(true) 
// {
//     Console.Write("Please enter a valid integer between 1 and 10: ");

//     int input = int.Parse(Console.ReadLine());

//     if(input >= 1 && input <= 10)
//     {
//         //  break the loop here
//         Console.WriteLine("Congratulations, you entered a valid integer");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("That's too bad, you entered and invalid input. Try again");
//     }
// }

//  We can do this in a for loop, but it's ugly and inconvenient for this case scenario
// for(int i = 0; i <= 0; i--)  // used the increment counter, so i < 0 will never happen, hence an infinity loop
// {
//     Console.Write("Please enter a valid integer between 1 and 10: ");

//     int input = int.Parse(Console.ReadLine());

//     if(input >= 1 && input <= 10)
//     {
//         //  break the loop here
//         Console.WriteLine("Congratulations, you entered a valid integer");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("That's too bad, you entered and invalid input. Try again");
//     }
// }


//  Assume the user enters valid information, no validation
Console.Write("How many studens do you have? ");
int students = int.Parse(Console.ReadLine());

//  Make an array for given number of students
int[] studentsFavoriteNumbers = new int[students];  //  the number of students in the classroom

//  For each of the student enter their favorite number
for(int i = 0; i < studentsFavoriteNumbers.Length; i++)
{
    Console.Write($"Enter the favorite number for student #{i + 1}: ");

    //  Assume input is valid
    studentsFavoriteNumbers[i] = int.Parse(Console.ReadLine());
}

//  Show the favorite number for each student
for(int i = 0; i < studentsFavoriteNumbers.Length; i++)
{
    Console.WriteLine($"Student number {i + 1}'s favorite number is {studentsFavoriteNumbers[i]}");
}