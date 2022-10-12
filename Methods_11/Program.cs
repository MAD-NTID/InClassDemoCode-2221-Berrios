//  Let's create a bark method that shows Woof! In the Console block
// Bark();
// Bark();
// Bark();

// void Bark() 
// {
//     Console.WriteLine("Woof!");
// }

// Bark(5);

// void Bark(int numberOfBarks) 
// {
//     for(int i = 0; i < numberOfBarks; i++)
//         Console.WriteLine("Woof!");
// }

// Console.Write("How many barks do you want the dog to bark? ");

// int numberOfBarks = int.Parse(Console.ReadLine());

// Bark(numberOfBarks);

// void Bark(int numberOfBarks) 
// {
//     //  if negative number or 0, bark loop will not run because i which is 0 is never less than the negative number
//     if(numberOfBarks < 0)
//     {
//         Console.WriteLine($"Dog will not bark with that number of barks input of {numberOfBarks}");
//     }

//     for(int i = 0; i < numberOfBarks; i++)
//         Console.WriteLine("Woof!");
// }

//  The traditional way
//double[] studentGrades = new double[6];

//  The shorty-joe way - this will create an array of 6 elements
// double[] studentGrades = {100, 75, 85, 75, 50, 90.25};
// double[] studentGrades2 = {65, 75, 85, 75, 75, 25.25};

// CalculateStudentGradesAverage(studentGrades);
// CalculateStudentGradesAverage(studentGrades2);

// void CalculateStudentGradesAverage(double[] studentGradesInMethod) 
// {
//     //  #1 Get the Sum of all grades
//     double studentGradeSum = 0;

//     for(int i = 0; i < studentGradesInMethod.Length; i++)
//     {
//         studentGradeSum += studentGradesInMethod[i];
//     }

//     //  #2 Get the average from the Sum of all grades
//     double studentGradeAverage = studentGradeSum / studentGradesInMethod.Length;

//     Console.WriteLine($"The sum of all student grades is {studentGradeSum}\nAverage is {studentGradeAverage}");
// }

double[] studentGrades = {100, 75, 85, 75, 50, 90.25};
double[] studentGrades2 = {65, 75, 85, 75, 75, 25.25};

Console.WriteLine($"The sum of all student grades is {CalculateStudentGradesSum(studentGrades)}\nAverage is {CalculateStudentGradesAverage(studentGrades)}");
Console.WriteLine($"The sum of all student grades is {CalculateStudentGradesSum(studentGrades2)}\nAverage is {CalculateStudentGradesAverage(studentGrades2)}");

double CalculateStudentGradesSum(double[] studentGradesInMethod)
{
    //  #1 Get the Sum of all grades
    double studentGradeSum = 0;

    for(int i = 0; i < studentGradesInMethod.Length; i++)
    {
        studentGradeSum += studentGradesInMethod[i];
    }

    return studentGradeSum;
}

double CalculateStudentGradesAverage(double[] studentGradesInMethod) 
{
    //  #2 Get the average from the Sum of all grades
    double studentGradeAverage = CalculateStudentGradesSum(studentGradesInMethod) / studentGradesInMethod.Length;

    return studentGradeAverage;
}
