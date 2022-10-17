public class Student
{
    public string firstname;
    public string lastname;
    public string major;
    public string degree;
    public double gpa;
    public int age;

    public void Jump() 
    {
        Console.WriteLine($"{firstname} Jumped!");
    }

    public void YellANumber(int number) 
    {
        Console.WriteLine($"{firstname} Yells the number {number}!");
    }

    public int Add(int num1, int num2)
    {
        int sum = num1 + num2;

        return sum;
    }

    public double GPA(double[] grades)
    {
        double gradesTotal = 0;

        for(int i = 0; i < grades.Length; i++)
        {
            gradesTotal += grades[i];
        }

        gpa = gradesTotal / grades.Length;

        return gpa;
    }
}