public class Dog
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string id, string name, string breed)
    {
        Id = id;
        Name = name;
        Breed = breed;
    }

    public override string ToString()
    {
        return $"ID: {Id}\nName: {Name} - Breed: {Breed}";
    }
}