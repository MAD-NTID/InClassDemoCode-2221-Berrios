public class Person
{
    public string Name { get; set; }   
    public int BirthYear { get; set; }

    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}