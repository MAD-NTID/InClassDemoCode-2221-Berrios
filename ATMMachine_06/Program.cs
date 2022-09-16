Console.Write("Please select the type of transaction you want from below\n" +
"1) Deposit\n2) Balance Inquiry\n3) Withdraw\n");

//  $1,500
double balance = 1500;
double deposit = 0;
double withdraw = 0;

string choice = Console.ReadLine();
switch(choice)
{
    //  This is for depositing money
    case "1":
    case "Deposit":
    case "deposit":
    Console.Write("How much do you want to deposit? ");

    deposit = double.Parse(Console.ReadLine());

    balance += deposit;

    Console.WriteLine($"You now have {balance:C}");
    break;

    //  This is for requesting how much money you have
    case "2":
    case "Balance Inquiry":
    case "balance inquiry":

    Console.WriteLine($"Your balance inquired is {balance:C}");
    break;

    //  This is for withdrawing money
    case "3":
    case "Withdraw":
    case "withdraw":
    Console.Write("How much do you want to withdraw? ");

    withdraw = double.Parse(Console.ReadLine());

    balance -= withdraw;

    Console.WriteLine($"You now have {balance:C}");
    break;
}