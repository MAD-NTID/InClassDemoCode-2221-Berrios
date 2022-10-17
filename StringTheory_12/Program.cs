string helloWorldString = "Hello World!";

for(int i = 0; i < helloWorldString.Length; i++)
{
    Console.Write(helloWorldString[i]);
}

Console.WriteLine();

//  hello world!
char[] helloArrayOfChar = new char[12];

helloArrayOfChar[0] = 'H';
helloArrayOfChar[1] = 'e';
helloArrayOfChar[2] = 'l';
helloArrayOfChar[3] = 'l';
helloArrayOfChar[4] = 'o';
helloArrayOfChar[5] = ' ';
helloArrayOfChar[6] = 'W';
helloArrayOfChar[7] = 'o';
helloArrayOfChar[8] = 'r';
helloArrayOfChar[9] = 'l';
helloArrayOfChar[10] = 'd';
helloArrayOfChar[11] = '!';

for(int i = 0; i < helloArrayOfChar.Length; i++)
{
    Console.Write(helloArrayOfChar[i]);
}

Console.WriteLine();

// How to create a swap names (the long way, without using the Split method)
string originalName = "John Doe";
string firstname = "";
string lastname = "";

// for(int i = 0; i < originalName.Length; i++)
// {
//     if(originalName[i] == ' ')
//     {
//         lastname = originalName.Substring(i + 1) + ", ";
//         break;
//     }
//     else
//     {
//         firstname += originalName[i];
//     }
// }

// string newName = lastname + firstname;

// Console.WriteLine(newName);

//  The short way using the Split method
string[] names = "John Doe".Split(" ");

string newName = names[1] + ", " + names[0];

Console.WriteLine(newName);