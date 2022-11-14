//  The value that we want to store are Dog objects
Dictionary<string, Dog> doggies = new Dictionary<string, Dog>() {
    {"abc123", new Dog("abc123", "Floffy", "Yorkshire Terries")},
    {"def456", new Dog("def456", "Booboo", "French Bulldog")}
};

while(true)
{
    Console.Write("Enter the dog's id: ");
    string id = Console.ReadLine();

    Console.Write("Enter the dog's name: ");
    string name = Console.ReadLine();

    Console.Write("Ent erthe dog's breed: ");
    string breed = Console.ReadLine();

    if(!(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(breed)))
    {
        //  Add the dog here
        if(doggies.ContainsKey(id))
        {
            Console.WriteLine($"This dog already exists, and its name is {doggies[id].Name}");
        }
        else
        {
            Console.WriteLine("This dog does not exists, so we add it.");

            // doggies.Add(id, new Dog(id, name, breed));
            Dog newDog = new(id, name, breed);
            doggies.Add(id, newDog);

            Console.WriteLine($"Dog {doggies[id].Name} has been added.");
        }

        Console.WriteLine();
        Console.Write("Do you want to add more dogs (y/n)? ");
        bool addMore = Console.ReadLine() == "y";

        if(!addMore)
            break;
    }
    else
    {
        Console.WriteLine("That's an invalid dog");
    }

    Console.WriteLine();
}

string[] menu = new string[] {"Remove", "Edit", "List", "Exit"};

while(true) 
{
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menu[i]}");
    }

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    if(choice == "1")
    {
        Console.Write("Enter the dog's id to remove: ");
        string dogId = Console.ReadLine();

        try
        {
            Dog doggie = doggies[dogId];

            // doggies.Remove(doggie.Id); // this id derived from the object of the dog already found
            // OR
            doggies.Remove(dogId);  // directly from user's input

            Console.WriteLine($"{doggie.Name} has been removed");
        }
        catch(KeyNotFoundException ThisCouldBeAnyNamedVariable)
        {
            Console.WriteLine(ThisCouldBeAnyNamedVariable);
            Console.WriteLine($"Exception Message: {ThisCouldBeAnyNamedVariable.Message}");

            Console.WriteLine($"The dog with id {dogId} was not found");
        }
        catch(Exception exception)
        {
            Console.WriteLine("If any other errors occurred here that I don't anticipate, catch it here");

            Console.WriteLine($"{exception.Message}");
        }

    }
    else if(choice == "2")
    {
        Console.Write("Enter the dog's id to edit: ");
        string dogId = Console.ReadLine();

        if(doggies.TryGetValue(dogId, out Dog dog))
        {
            Console.WriteLine($"{dog.Name} was found");

            Console.Write("Enter the new dog's name: ");
            string name = Console.ReadLine();

            Console.Write("Ent erthe new dog's breed: ");
            string breed = Console.ReadLine();

            string dogOldName = dog.Name;
            string dogOldBreed = dog.Breed;

            dog.Name = name;
            dog.Breed = breed;

            doggies[dog.Id] = dog;

            Console.WriteLine($"Dog {dogOldName} was modified to {dog.Name}, and breed from {dogOldBreed} to {dog.Breed}");
        }
        else
        {
            Console.WriteLine($"Sorry, that dog id {dogId} was not found");
        }
    }
    else if(choice == "3")
    {
        Console.WriteLine($"{doggies.Count} dogs found");

        /**
            When you do a foreach and you would like to get the properties from the object, you must first get the 'Value' from the keyed dictionary.
            The 'Value' is the Dog object in this case because the dictionary declaration is Dictionary<string, Dog> || Dictionary<key, value>
        **/
        foreach(KeyValuePair<string, Dog> dog in doggies)
            Console.WriteLine($"ID: {dog.Value.Id}\nName: {dog.Value.Name} - Breed: {dog.Value.Breed}\n");
    }
    else if(choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }

    Console.WriteLine();
}