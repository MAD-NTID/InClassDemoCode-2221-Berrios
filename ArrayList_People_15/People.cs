public class People
{
    //  Declare Only
    private List<Person> people;

    public People()
    {
        //  Initialize Private Fields in the Constructor
        people = new List<Person>();
    }

    //  Add
    public void Add(Person person)
    {
        people.Add(person);
    }
    
    //  Add to Beginning
    public void AddToBeginning(Person person)
    {
        people.Insert(0, person);
    }

    //  Remove
    public void Remove(Person person)
    {
        people.Remove(person);
    }

    //  List out all people
    public List<Person> Get()
    {
        return people;
    }

    //  Edit
    public bool Edit(string name, Person edited)
    {
        if(this.Exists(name))
        {
            Person personToEdit = Find(name);

            people[personToEdit] = edited;

            return true;
        }

        return false;
    }


    //  Find
    public Person Find(string name)
    {
        foreach(Person person in people)
        {
            if(person.Name == name)
            {
                return person;
            }
        }

        return null;
    }

    public bool Exists(Person person)
    {
        if(people.IndexOf(person) > -1)
            return true;

        return false;
    }

    //  Count

    public override string ToString()
    {
        string peopleDetails = "";

        foreach(Person person in people)
        {
            peopleDetails += person.ToString() + "\n\n";
        }

        return peopleDetails;
    }
}