//  Creates an empty list of Person objects
List<Person> people = new List<Person>();

Console.WriteLine($"People List Count (Before): {people.Count}");

//  Let's add a person, the simple way, first
Person ashley = new Person("Ashley", 2000);
people.Add(ashley);

Console.WriteLine($"{ashley} was added to the list");
Console.WriteLine();

//  Let's add a person directly in the Add method of the List object
people.Add(new Person("Patrick", 2003));
Console.WriteLine($"{people[1]} was added to the list");
Console.WriteLine();
//  Let's attempt to add a string object - this causes a run time error
//people.Add("This is a string, is it valid?");

//  Let's attempt to add a double object - this causes a run time error too
//people.Add(200.15);

//  Let's add a person by collecting input
Console.Write("Enter the name of the person to add: ");
string name = Console.ReadLine();

Console.Write("Enter the birthyear of the person: ");
int birthYear = int.Parse(Console.ReadLine());

people.Add(new Person(name, birthYear));
Console.WriteLine($"{people[2]} was added to the list");
Console.WriteLine();

//  Let's remove a person by using the index position
Person whoIsOnIndexZero = people[0];
Console.WriteLine($"{whoIsOnIndexZero} is currently on index 0");
people.RemoveAt(0);
Console.WriteLine($"{whoIsOnIndexZero} has been removed");
Console.WriteLine();

//  Let's modify a person by using the index position (long way)
Person whoeverItIs = people[0];
Console.WriteLine($"{whoeverItIs} is currently on index 0");
whoeverItIs.Name = "Keegan";
whoeverItIs.BirthYear = 2002;
people[0] = whoeverItIs;
Console.WriteLine($"{people[0]} is not on index 0");

//  Let's modify a person by using the index position (short way)
//people[0] = people[0].Name = "Keegan";
Console.WriteLine();

Console.WriteLine();
//  Let's remove a person by object reference, not by index position
Person personToRemove = null;
foreach(Person person in people)
{
    if(person.Name == "Keegan")
    {
        personToRemove = person;
        break;
    }
}

//  Remove a person from the list without using the index, but by using the object reference
//  This means, you don't need to know which index they're currently stored at in the list
people.Remove(personToRemove);
Console.WriteLine($"{personToRemove} has been removed from the list");
Console.WriteLine();

if(people.Count == 1)
{
    Console.WriteLine($"{people[0]} is the last person left in the list at index 0");
    Console.WriteLine();
}

//  This is the BEFORE using the Insert method
foreach(Person person in people)
{
    Console.WriteLine($"Currently Iterating {person}");
}

Console.WriteLine();
Person johnny = new Person("Johhny", 2004);
people.Insert(0, johnny);

Console.WriteLine($"{johnny} was added to the list via the Insert method, which pushed\n{people[1]} to index 1");
Console.WriteLine();

//  This is the AFTER using the Insert method - if you insert to an index that already exists,
//  The object at the index gets pushed to the next index position
foreach(Person person in people)
{
    Console.WriteLine($"Currently Iterating {person} at index {people.IndexOf(person)}");
}

Console.WriteLine();
Console.WriteLine($"People List Count (After): {people.Count}");