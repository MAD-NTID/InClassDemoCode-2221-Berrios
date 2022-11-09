string[] menu = {
    "Add",
    "AddToBeginning",
    "Remove",
    "Edit",
    "Find",
    "Exists",
    "Count",
    "List All",
    "Clear",
    "Exit"
};

People people = new People();

while(true)
{
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menu[i]}");
    }

    Console.Write("Enter your choice: ");
    string menuChoice = Console.ReadLine();

    if(menuChoice == "1")
    {
        Console.Write("What is the person's name: ");
        string name = Console.ReadLine();

        Console.Write("What is the person's birthyear: ");
        int birthYear = int.Parse(Console.ReadLine());

        Person person = new Person(name, birthYear);

        people.Add(person);
    }
    else if(menuChoice == "2")
    {
        Console.Write("What is the person's name: ");
        string name = Console.ReadLine();

        Console.Write("What is the person's birthyear: ");
        int birthYear = int.Parse(Console.ReadLine());

        Person person = new Person(name, birthYear);

        people.AddToBeginning(person);
    }
    else if(menuChoice == "3")
    {
        Console.Write("What is the person's name to remove: ");
        string name = Console.ReadLine();

        if(people.Exists(name))
        {
            Person person = people.Find(name);

            people.Remove(person);

            Console.WriteLine($"{person.Name} was removed");
        }
        else
        {
            Console.WriteLine("Sorry, that person was not found");
        }
    }
    else if(menuChoice == "4")
    {
        Console.Write("What is the person's name to edit: ");
        string name = Console.ReadLine();

        if(people.Exists(name))
        {
            Person person = people.Find(name);

            Console.Write("What is the new name? ");
            string newName = Console.ReadLine();

            Console.Write("What is the new birthyear? ");
            int birthYear = int.Parse(Console.ReadLine());

            person.Name = newName;
            person.BirthYear = birthYear;

            if(people.Edit(name, person))
            {
                Console.WriteLine("Person was updated");
            }
            else
            {
                Console.WriteLine("Failed to update person");
            }
        }
        else
        {
            Console.WriteLine("Sorry, that person was not found");
        }
    }
    else if(menuChoice == "5")
    {
        Console.Write("What is the person's name to Find: ");
        string name = Console.ReadLine();

        if(people.Exists(name))
        {
            Person person = people.Find(name);

            Console.WriteLine(person);
        }
        else
        {
            Console.WriteLine("Sorry, that person was not found");
        }
    }
    else if(menuChoice == "6")
    {
        Console.Write("What is the person's name to remove: ");
        string name = Console.ReadLine();

        if(people.Exists(name))
        {
            Console.WriteLine($"Yes, {name} exists");
        }
        else
        {
            Console.WriteLine("Sorry, that person was not found");
        }
    }
    else if(menuChoice == "7")
    {
        Console.WriteLine($"There are {people.Count()} Person objects in the People object");
    }
    else if(menuChoice == "8")
    {
        Console.WriteLine(people.ToString() != "" ? people : "No People Exists");

        //  The Above Ternary Expression is the same as this below
        // if(people != "")
        //     Console.WriteLine(people);
        // else
        //     Console.WriteLine("No People Exists");
    }
    else if(menuChoice == "9")
    {
        people.Clear();
        Console.WriteLine("List has been cleared");
    }
    else if(menuChoice == "10")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }

    //  Spacer
    Console.WriteLine();
}
