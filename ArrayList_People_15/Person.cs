public class Person
{
    private string name;
    public string Name { get {return name;} set {name = value;} }   

    public int BirthYear { get; set; }

    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    public override string ToString()
    {
        return string.Format($"Name: {Name} - BirthYear: {BirthYear}");
    }
}