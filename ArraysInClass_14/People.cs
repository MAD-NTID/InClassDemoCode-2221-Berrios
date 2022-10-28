public class People
{
    private Person[] arrayOfPerson;

    public People(int size)
    {
        arrayOfPerson = new Person[size];
    }

    public void Add(string name, int birthYear)
    {
        Console.WriteLine($"Name: {name}\nBirthYear: {birthYear}");

        for (int i = 0; i < arrayOfPerson.Length; i++)
        {
            if(arrayOfPerson[i] == null)
            {
                arrayOfPerson[i] = new Person(name, birthYear);
                break;
            }
        }
    }

    /// <summary>
    /// This function will loop over the array of person.
    /// Finds objects that are not null.
    /// Assign the not null object to the temporary array.
    /// And then return an array of person that has NO null objects
    /// </summary>
    /// <returns></returns>
    public Person[] Get()
    {
        //  Set the temporary array to the size of the array that actually has 'instances' of Person object
        //  So we create a separate method to handle just that.
        //  Why? Because the goal of this methods is to eliminate null.
        //  Example: People class declares array of 5 people, but we only have 2 'instances'
        //  Then let's create a temporary array that holds 2 Person objects
        //  Then get those object and return temporary array
        //  Now, temporary array has no "null" objects
        Person[] temporary = new Person[Length()];
        int index = 0;
        
        for (int i = 0; i < arrayOfPerson.Length; i++)
        {
            if(arrayOfPerson[i] != null)
            {
                temporary[index] = arrayOfPerson[i];
                index++;
            }
        }
            
        return temporary;
    }

    //  This function will return the count of objects that are not null in the 
    //  Person array 
    public int Length()
    {
        int count = 0;

        foreach (Person person in arrayOfPerson)
        {
            if(person != null)
                count++;
        }

        return count;
    }
}