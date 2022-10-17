Student erik = new Student();

erik.firstname = "Erik";
erik.lastname = "Menchaca";
erik.major = "Information and Computing Studies";
erik.degree = "Masters";
erik.gpa = 4;
erik.age = 25;

Console.WriteLine($"I just created a Student object with a variable name of 'erik'\n" +
$"The Student object has firstname: {erik.firstname}, lastname: {erik.lastname}, major: {erik.major}, degree: {erik.degree}, gpa: {erik.gpa}, and age:{erik.age}.");

Console.WriteLine();

erik.Jump();

erik.YellANumber(10);

int erikAddedNumbers = erik.Add(5, 10);

Console.WriteLine($"{erik.firstname} added 5 + 10 which equals = {erikAddedNumbers}");

double[] grades = new double[3];
grades[0] = 99;
grades[1] = 75;
grades[2] = 65;

Console.WriteLine($"{erik.firstname}'s GPA is " + erik.GPA(grades));
