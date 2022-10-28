People people = new People(6);

people.Add("Erik", 2001);

//  using foreach loop
foreach (Person person in people.Get())
{
    //  No need to check for Null anymore
    Console.WriteLine(person.Name);
}