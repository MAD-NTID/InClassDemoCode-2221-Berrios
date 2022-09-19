const string BUSINESS_NAME = "Loco's Ice Cream Parlour";

Console.WriteLine($"Welcome to {BUSINESS_NAME}");

const string CHOCOLATE = "Chocolate",
    VANILLA = "Vanilla",
    STRAWBERRY = "Strawberry";

const double SCOOP_PRICE = 1.5;
const int MAX_SCOOP = 5;

const double CUP_PRICE = .5,
    CONE_PRICE = 1;

const double NYS_TAX_RATE = .08;

//  Show the Cup / Cone Options
Console.WriteLine(
"========================================\n" +
"Cone / Cup:\n" +
$"\t1. Cup {CUP_PRICE:C}\n" +
$"\t2. Cone {CONE_PRICE:C}"
);

Console.Write("Select a Cup or Cone (1 or 2): ");

if(int.TryParse(Console.ReadLine(), out int coneOrCupChoice) && (coneOrCupChoice >= 1 && coneOrCupChoice <= 2)) 
{
    //  Cup or Cone is Valid, so we continue the program, naturally
    //  We continue to get the Ice Cream Flavors
    Console.WriteLine();

    Console.WriteLine(
    "Flavors:\n" +
    $"\t1. {CHOCOLATE}\n" +
    $"\t2. {VANILLA}\n" +
    $"\t3. {STRAWBERRY}");

    Console.Write("Select a flavor: ");

    if(int.TryParse(Console.ReadLine(), out int flavorChoice) && (flavorChoice >= 1 && flavorChoice <= 3))
    {
        //  Convert the flavorChoice to a String
        string flavorChoiceString = "";

        switch(flavorChoice)
        {
            case 1:
                flavorChoiceString = "Chocolate";
                break;
            case 2:
                flavorChoiceString = "Vanilla";
                break;
            default:
                flavorChoiceString = "Strawberry";
                break;
        }

        //  Ice cream flavor is valid, continue to prompt for how many scoops
        Console.WriteLine();

        Console.Write(
        $"Scoops {SCOOP_PRICE:C} per Scoop\n" +
        $"How many scoops do you want? (Max: {MAX_SCOOP}): "
        );

        //  This checks if the input is valid, and we stored the validity to a 
        //  boolean variable
        bool scoopValid = int.TryParse(Console.ReadLine(), out int scoops);

        //  Now we check whether or not it's valid input
        if(scoopValid == true)
        {
            if(scoops >= 1 && scoops <= MAX_SCOOP)
            {
                string cupOrConeChoiceString = "";
                double cupOrConeChoicePrice = 0;
                double subtotal = 0;

                //  It's valid, stuff to do here like calculations and ... etc
                if(coneOrCupChoice == 1)
                {
                    //  it is a cup
                    cupOrConeChoiceString = "Cup";
                    cupOrConeChoicePrice = CUP_PRICE;
                    subtotal += cupOrConeChoicePrice;
                }
                else
                {
                    //  it is a cone
                    cupOrConeChoiceString = "Cone";
                    subtotal += cupOrConeChoicePrice = CONE_PRICE;
                }
                
                //  Add the price of the scoops
                subtotal += scoops * SCOOP_PRICE;

                //  Get the tax of the subtotal
                double tax = subtotal * NYS_TAX_RATE;

                double total = subtotal + tax;

                //  Finally, we can output information
                Console.WriteLine(
                    "RECEIPT\n\n" +
                    $"{cupOrConeChoiceString} @ {cupOrConeChoicePrice:C} /each\n" +
                    $"Flavor: {flavorChoiceString}\n" +
                    $"Scoops: {scoops} @ {SCOOP_PRICE:C} /each\n" +
                    $"Tax: {tax:C}\n" +
                    $"Your total is: {total:C}"
                );
            }
            else
            {
                Console.WriteLine($"Invalid number of scoops, please enter between 1 & {MAX_SCOOP}");
            }
        }
        else
        {
            Console.WriteLine($"Invalid input, enter whole numbers between 1 and {MAX_SCOOP}");
        }
    }
    else
    {
        //  Ice cream flavor is not valid, we continue the program, naturally, it will end...naturally
        Console.WriteLine("Invalid ice cream flavor. Please select between 1 and 3");
    }
}
else
{
    //  If Cup or Cone is not Valid, we continue the program, naturally, it will end...naturally.
    Console.WriteLine("Invalid choice of Cup or Cone, please enter number between 1 and 2");
}

//  There's nothing here, so program will end... naturally