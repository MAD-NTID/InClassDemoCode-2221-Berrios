// double[] testScores = new double[5];

// for(int i = 0; i < testScores.Length; i++)
// {
//     Console.Write($"Enter a score for test #{i + 1}: ");
//     testScores[i] = double.Parse(Console.ReadLine());
// }

// double testScoresSum = 0;

// for(int i = 0; i < testScores.Length; i++)
// {
//     testScoresSum += testScores[i];
// }

// Console.WriteLine($"The total sum of the tests is {testScoresSum}");

// double average = testScoresSum / testScores.Length;

// Console.WriteLine($"And the average is {average}");

//  Create a Parallel array that collect student names and their final grades
string[] studentNames = new string[7];
double[] studentGrades = new double[studentNames.Length];

//  Collect the student names and their grade
for(int i = 0; i < studentNames.Length; i++)
{
    Console.Write($"Enter the student name for student #{i + 1}: ");

    //  Assume data is never empty
    studentNames[i] = Console.ReadLine();

    Console.Write($"Enter the final grade for the student #{i + 1}: ");

    //  Assume data is always valid
    studentGrades[i] = double.Parse(Console.ReadLine());
}

//  Show student names and grades using another for loop
for(int i = 0; i < studentGrades.Length; i++)
{
    Console.WriteLine($"Student Name: {studentNames[i]}\tGrade: {studentGrades[i]}");
}

//  Allows user to enter a student name and show the student details, grades.
// Console.Write("Enter a student name: ");
// string studentNameLookup = Console.ReadLine();

//  Perform a lookup using for loop
// for(int i = 0; i < studentNames.Length; i++)
// {
//     if(studentNames[i].ToLower() == studentNameLookup.ToLower())
//     {
//         Console.WriteLine($"Student Name: {studentNames[i]}\tGrade: {studentGrades[i]}");
//         break;
//     }
// }

//  Perform a lookup using for loop, and re-prompt for student name if student is not found, use a control variable for while loop
bool found = false;

while(!found) 
{
    Console.Write("Enter a student name: ");
    string studentNameLookup = Console.ReadLine();

    //  Loop the array in search of the student name
    for(int i = 0; i < studentNames.Length; i++)
    {
        if(studentNames[i].ToLower() == studentNameLookup.ToLower())
        {
            Console.WriteLine($"Student '{studentNameLookup}' was found");
            Console.WriteLine($"Student Name: {studentNames[i]}\tGrade: {studentGrades[i]}");            
            found = true;
        }
    }

    if(!found)
    {
        Console.WriteLine($"Student '{studentNameLookup}' was not found, try again");
    }

    //  Adds a space for the next prompt
    Console.WriteLine();
}