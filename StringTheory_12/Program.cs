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