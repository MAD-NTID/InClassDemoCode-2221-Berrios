public class Student
{
    public string firstname;
    public string lastname;
    public string major;
    public string degree;
    public double gpa;
    public int age;

    //  This is the default constructor for the Student class
    public Student()
    {
        firstname = "Not Assigned";
        lastname = "Not Assigned";
        major = "Not Assigned";
        degree = "Not Assigned";
    }

    //  A different signature of the constructor method to not require age
    public Student(string firstname, string lastname, string major, string degree, double gpa)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.major = major;
        this.degree = degree;
        this.gpa = gpa;
    }

    //  A constructor with all of the parameters but makes age optional
    public Student(string firstname, string lastname, string major, string degree, double gpa, int age = 18)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.major = major;
        this.degree = degree;
        this.gpa = gpa;
        this.age = age;
    }

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