class Program
{
    static string hello2 = "Hello World";


    public static void Main(string[] args) 
    {
        //Add(5, 2);
        //Add(5, 2, 1);

        // Console.WriteLine(hello);    // This one will throw a compiler error because hello does not exists in current context
        //Console.WriteLine(hello2);

        //Multiply();    //  Calling the method that has the optional parameter

        //Divide(num2: 1, num1: 0);

        //Divide(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

        //Divide();

        Console.Write("Enter Number 1 to do sum: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2 to do sum: ");
        int num2 = int.Parse(Console.ReadLine());

        //  Now we do the sum, and validate that the results are not less than 0
        bool sumPassedOrFailed = DoSumAndOutParamter(num1, num2, out int result);

        if(sumPassedOrFailed)
        {
            Console.WriteLine($"The sum of the number is {result}");
        }
        else
        {
            Console.WriteLine("The sum of the number is a negative value");
        }
    }

    static void Add(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    static void Add(int num1, int num2, int num3)
    {
        Console.WriteLine(num1 + num2 + num3);
    }

    static void Multiply(int num1 = 0, int num2 = 0)
    {
        Console.WriteLine(num1 * num2);
    }
    
    static void Divide(double num1 = 0, double num2 = 1)
    {
        Console.WriteLine(num1 / num2);
    }

    static bool DoSumAndOutParamter(int num1, int num2, out int result)
    {
        result = num1 + num2;

        if(result < 0)
        {
            return false;   
        }

        return true;
    }

    static void SomeMethod()
    {
        //  the variable hello is inside the scope of the method 'SomeMethod'
        string hello = "Hello World";
    }
}
