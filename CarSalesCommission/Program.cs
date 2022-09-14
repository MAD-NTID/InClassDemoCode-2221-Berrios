Console.Write("Name of the Seller: ");
string nameOfSeller = Console.ReadLine();

//  declaration of the amountOfSale variable and initialized with input value
Console.Write("Enter amount of sale: ");
double amountOfSale = double.Parse(Console.ReadLine());

const double COMMISSION = .07; // 7% commission
double salesPurchaseCommission = 0; // start 0 commission

if(amountOfSale >= 10000) 
{
    salesPurchaseCommission = amountOfSale * COMMISSION;    
}

Console.WriteLine();
Console.WriteLine("Salesperson: {0}", nameOfSeller);
Console.WriteLine("Total Sale: {0:C}", amountOfSale);
Console.WriteLine("Commission: {0:C}", salesPurchaseCommission);