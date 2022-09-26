const string BUSINESS_NAME = "Disks4Cheap";
const double HARD_DRIVE_PRICE = 25.75;

Console.WriteLine($"***{BUSINESS_NAME}***");

Console.Write("How many disk drives are in the current inventory? ");

if(int.TryParse(Console.ReadLine(), out int inventoryCount)) 
{
    //  Input is valid, show menu
    Console.WriteLine("MENU");
    Console.WriteLine("1. Display the current inventory");
    Console.WriteLine($"2. Buy disks from {BUSINESS_NAME}");
    Console.Write($"3. Sell disks to {BUSINESS_NAME}\n" +
    "4. Exit\n" + 
    "Enter your choice (1, 2, 3 or 4): ");

    if(int.TryParse(Console.ReadLine(), out int choice) && (choice > 0 && choice < 5)) 
    {
        double inventoryCost = inventoryCount * HARD_DRIVE_PRICE;

        switch(choice)
        {
            case 1:
                Console.WriteLine($"Inventory Count: {inventoryCount}");
                Console.WriteLine($"Disks Inventory Value: {inventoryCost:C}\n" +
                "Program end... Exit");
                break;
            case 2:
                Console.Write("How many disks would you like to buy? ");
                bool tempNumber = int.TryParse(Console.ReadLine(), out int disksBuy);

                //  we are buying from the store, what happens to the inventory count now?
                if(tempNumber && (disksBuy >= 0 && disksBuy <= inventoryCount))
                {
                    //  Substract the number of disks purchased from inventory
                    inventoryCount -= disksBuy;
                    inventoryCost = inventoryCount * HARD_DRIVE_PRICE;                    

                    Console.WriteLine($"Inventory Count: {inventoryCount}");
                    Console.WriteLine($"Disks Inventory Value: {inventoryCost:C}\n" +
                    "Program end... Exit");
                }
                else
                {
                    Console.WriteLine("Bad value entered");
                }

                break;
            case 3:
                Console.WriteLine("How many disks would you like to sell? ");

                bool disksSell = int.TryParse(Console.ReadLine(), out int sellAmount);

                if(disksSell && sellAmount >= 0)
                {
                    inventoryCount += sellAmount;

                    inventoryCost = inventoryCount * HARD_DRIVE_PRICE;                    

                    Console.WriteLine($"Inventory Count: {inventoryCount}");
                    Console.WriteLine($"Disks Inventory Value: {inventoryCost:C}\n" +
                    "Program end... Exit");
                }
                else
                {
                    Console.WriteLine("Invalid number amount of disks");
                }

                break;
            case 4:
                Console.WriteLine("Thank you for visiting us.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Error: The value you entered is invalid");
    }
}
else
{
    Console.WriteLine("Error: The value you entered is incorrect... exiting");
}