// Student student_1 = new Student();

// student_1.firstname = "Erik";
// student_1.lastname = "Menchaca";
// student_1.major = "Information and Computing Studies";
// student_1.degree = "Masters";
// student_1.gpa = 4;
// student_1.age = 25;

// Console.WriteLine($"Name: {student_1.firstname} {student_1.lastname}\n" +
// $"Major: {student_1.major}\n" +
// $"Degree: {student_1.degree}\n" +
// $"GPA: {student_1.gpa}\n" + 
// $"Age: {student_1.age}");

//  Console.WriteLine();

// Student student_2 = new Student("Joseph", "McEnroe", "ACT", "PhD", 3.5);

// Console.WriteLine($"Name: {student_2.firstname} {student_2.lastname}\n" +
// $"Major: {student_2.major}\n" +
// $"Degree: {student_2.degree}\n" +
// $"GPA: {student_2.gpa}\n" + 
// $"Age: {student_2.age}");

Student[] students = new Student[3];

for(int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Collecting Information for Student # {i + 1}");

    //  Prompt for the first name
    Console.Write("What is your first name? ");
    string firstname = Console.ReadLine();

    //  Prompt for the last name
    Console.Write("What is your last name? ");
    string lastname = Console.ReadLine();

    //  Prompt for the major
    Console.Write("What is your major? ");
    string major = Console.ReadLine();

    //  Prompt for the degree
    Console.Write("What is your degree? ");
    string degree = Console.ReadLine();

    //  Prompt for gpa
    Console.Write("What is your GPA? ");
    double gpa = double.Parse(Console.ReadLine());

    //  Prompt for age
    Console.Write("What is your Age? ");
    int age = int.Parse(Console.ReadLine());

    Student student = new Student(firstname, lastname, major, degree, gpa, age);

    students[i] = student;
}

Console.WriteLine("List of Students: \n");
for(int i = 0; i < students.Length; i++)
{
    // Student student = students[i];

    // Console.WriteLine($"Name: {student.firstname} {student.lastname}\n" +
    // $"Major: {student.major}\n" +
    // $"Degree: {student.degree}\n" +
    // $"GPA: {student.gpa}\n" + 
    // $"Age: {student.age}");

    Console.WriteLine($"Name: {students[i].firstname} {students[i].lastname}\n" +
    $"Major: {students[i].major}\n" +
    $"Degree: {students[i].degree}\n" +
    $"GPA: {students[i].gpa}\n" + 
    $"Age: {students[i].age}");

    Console.WriteLine();
}