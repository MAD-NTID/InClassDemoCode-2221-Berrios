#region Predefined Code, DO NOT MODIFY
const string HEADER = "MAD4UFOS Data Collection System";
const string DASHER = "--------";

string[] menu = { 
    "Enter a Sighting", 
    "Display all sightings", 
    "Display sightings filtered by species", 
    "Display Record Count", 
    "Exit" 
};

Alien[] aliens = Array.Empty<Alien>();
#endregion


Console.Title = HEADER;

#region STUDENT CODE HERE
/*
 * Uncomment this method when you are ready to code for it
 * Create the method in the Region STUDENT METHOD CODES HERE
 * */
DisplayHeader();

/*
 * This while loop is controlled by the continueProgram bool variable
 * For exiting this loop, set the continueProgram variable to false as needed
 * 
 * You may optional use Environment.Exit(0)
 * */
bool continueProgram = true;
while (continueProgram)
{
    /*
     * Uncomment this method when you are ready to code for it
     * Create the method in the Region STUDENT METHOD CODES HERE
     * */
    DisplayMenu();
    
    switch (GetMenuSelection())
    {
        case 1:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            EnterASighting();

            break;
        case 2:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayAllSightings();

            break;
        case 3:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            FilterBySpecies();

            break;
        case 4:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayRecordCount();

            break;
        case 5:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            continueProgram = !Exit();

            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==> Invalid choice");
            Console.ResetColor();

            break;
    }
}
#endregion

#region STUDENT METHOD CODES HERE
//  Code for DisplayHeader() here
void DisplayHeader() 
{
    Console.WriteLine(HEADER);
    Console.WriteLine(DateTime.Now.ToString());
    Console.WriteLine();
}

//  Code for DisplayMenu() here
void DisplayMenu()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("=========");
    
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"  {i + 1}. {menu[i]}");
    }

    Console.Write($"Enter your selection (1 - {menu.Length}): ");
}

//  Code for EnterASighting() here
void EnterASighting()
{
    //  While Loop for Specie Name
    while(true)
    {
        Console.Write($"Enter the species (");
    
        foreach(string specie in Alien.species)
        {
            Console.Write($"{specie},");
        }

        Console.Write($"): ");

        string specieInput = Console.ReadLine();

        if(Alien.HaveSpecies(specieInput))
        {
            //  While Loop for Date
            while(true)
            {
                Console.Write("Enter the Date of the sighting as mm/dd/yyyy: ");

                string dateInput = Console.ReadLine();

                if(Alien.DateIsValid(dateInput))
                {

                    //  While Loop for Location
                    while(true)
                    {
                        Console.Write("Enter the location of the sighting: ");

                        string locationInput = Console.ReadLine();

                        if(!string.IsNullOrEmpty(locationInput))
                        {
                            Console.WriteLine("Location is valid");
                            
                            Alien alien = new Alien(specieInput, dateInput, locationInput);

                            IncreaseAliensArraySize();

                            //  Grab the last index of aliens by using the length property
                            aliens[aliens.Length - 1] = alien;

                            //  Location of the sighting is valid
                            break;
                        }
                        else
                        {
                            Console.WriteLine("==> You must enter the location of the sighting");
                        }
                    }

                    //  Enter the Date is Valid
                    break;
                }
                else
                {
                    Console.WriteLine("==> You must enter the date of the sighting");
                }
            }

            //  Enter a Specie Name is valid
            break;
        }
        else
        {
            Console.WriteLine("==> You must enter a valid specie's name");
        }
    }
}

//  Code for DisplayAllSightings() here
void DisplayAllSightings()
{
    if(aliens.Length > 0)
    {
        DisplaySightingsHeader();

        foreach(Alien alien in aliens)
        {
            Console.WriteLine(alien);
        }

        Console.WriteLine($"==> {aliens.Length} records found");
    }
    else
    {
        Console.WriteLine("No alien sighted");
    }
}

//  Code for FilterBySpecies() here
void FilterBySpecies()
{
    if(aliens.Length > 0)
    {
        Console.Write("Enter a specie to filter by: ");

        string filterSpecie = Console.ReadLine();

        DisplaySightingsHeader();

        int counter = 0;
        foreach(Alien alien in aliens)
        {
            if(alien.Name.ToLower() == filterSpecie.ToLower())
            {
                Console.WriteLine(alien);
                // counter ++;
                counter += 1;
            }
        }

        //  Alternatively...
        // for(int i = 0; i < aliens.Length; i++)
        // {
        //     if(aliens[i].Name.ToLower() == filterSpecie.ToLower())
        //     {
        //         Console.WriteLine(aliens[i]);
        //         counter ++;
        //     }
        // }

        Console.WriteLine($"==> {counter} records found");
    }
    else
    {
        Console.WriteLine("No aliens in the registry");
    }
}

//  Code for DisplayRecordCount() here
void DisplayRecordCount() 
{
    Console.WriteLine($"==> {aliens.Length} records sighted");
}

//  Code for Exit() here
bool Exit()
{
    while(true)
    {
        Console.Write("Do you really want to exit? Press 'Y' to confirm: ");

        string exitInput = Console.ReadLine();

        if(exitInput == "Y" || exitInput == "y")
        {
            Console.WriteLine($"Thank you for using {HEADER}. Goodbye!");
            return true;
        }
        else if(exitInput == "N" || exitInput == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Unknown Response");
            return false;
        }
    }
}
#endregion

#region PREDEFINED CODE, DO NOT MODIFY
/// <summary>
/// This method will validate that the menu choice is valid.
/// </summary>
/// <returns>Returns the int value for the menu selection made</returns>
int GetMenuSelection()
{
    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= menu.Length)
        return choice;

    return -1;
}

/// <summary>
/// This method takes care of increasing the array by 1 index so that any new Alien object can be added to the aliens Array
/// </summary>
/// <param name="aliens">Accepts a parameter of Aliens</param>
void IncreaseAliensArraySize()
{
    Array.Resize(ref aliens, aliens.Length + 1);
}

/// <summary>
/// This method can be used when you want to display a header for all the Alien sightings before listing them
/// </summary>
static void DisplaySightingsHeader()
{
    Console.WriteLine($"{"Species", Alien.RIGHT_SPACER} {"Date", Alien.LEFT_SPACER} {"Location", Alien.RIGHT_SPACER}");
    Console.WriteLine($"{DASHER, Alien.RIGHT_SPACER} {DASHER, Alien.LEFT_SPACER} {DASHER, Alien.RIGHT_SPACER}");
}
#endregion