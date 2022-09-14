Console.WriteLine("Test that ((true && true) || false) is true by Ashley Locatelli");

if((true && true) || false) 
{
    Console.WriteLine("Ashley was right");
}
else 
{
    Console.WriteLine("Ashley was wrong");
}

Console.WriteLine();

Console.WriteLine("Test that (false && true || (true && false)) is false by Johnny Quinn");

if(false && true || (true && false)) 
{
    Console.WriteLine("Johnny was wrong");
}
else 
{
    Console.WriteLine("Johnny was right");
}

Console.WriteLine();

Console.WriteLine("Test that ((true && true || false) && true || (false)) is true by Erik Menchaca");

if((true && true || false) && true || (false)) 
{
    Console.WriteLine("Erik was right");
}
else 
{
    Console.WriteLine("Erik was wrong");
}