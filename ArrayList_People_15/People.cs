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
        Person person = Find(name);

        if(person != null)    
        {
            //  This should work but it's not working.... hold on to this
            //people[person] = edited;

            //  Let's instead get the index where this object is located
            int index = people.IndexOf(person);
            people[index] = edited;

            return true;
        }

        return false;
    }


    //  Find
    public Person Find(Person person)
    {
        int index = people.IndexOf(person);

        if(index > -1)
            return people[index];

        return null; 
    }

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

    public bool Exists(string name)
    {
        Person person = Find(name);

        return person != null;
    }

    //  Count
    public int Count()
    {
        return people.Count;
    }

    public void Clear()
    {
        people = new List<Person>();
    }

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