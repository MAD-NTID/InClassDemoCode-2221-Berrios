const string BUSINESS_NAME = "WingsHeaven";

//  You can declare and initialize multiple variables of the same 
//  datatype in one statement separated by a comma
const double BONELESS = 7.99,
    TRADITIONAL = 9.99,
    BOTH_WINGS = 17.98;

const double BOTH_WINGS_DISCOUNT = .18; //18%

//  You can declare and initialize multiple variables of the same 
//  datatype in one statement separated by a comma
const double BUFFALO_SAUCE = .29,
    MILD_SAUCE = .39,
    BBQ_SAUCE = .29,
    PLAIN_SAUCE = 0;

//  You can declare and initialize multiple variables of the same 
//  datatype in one statement separated by a comma
const double WAFFLE_FRIES_SIDE = 3.49,
    ONION_RINGS_SIDE = 2.49,
    BOTH_SIDES = 5.98,
    NONE_SIDES = 0;

const double NYS_TAX_RATE = .08; // 8%

Console.WriteLine($"***{BUSINESS_NAME}***");

//  Prompt the user for the type of wings they want
Console.Write("Type of Wings:\n" +
$"1. Boneless Wings {BONELESS:C}\n" +
$"2. Traditional Wings {TRADITIONAL:C}\n" +
$"3. Both {BOTH_WINGS:C}\n" +
"Enter your selection: "
);

//  The professor didn't ask to validate, so use parse
int wingsSelection = int.Parse(Console.ReadLine());

//  Gets the price of the wings the customer selected
double wingsPrice = 0;
string wingType = "";

if(wingsSelection == 1)
{
    wingsPrice = BONELESS;
    wingType = "Boneless";
}
else if(wingsSelection == 2)
{
    wingsPrice = TRADITIONAL;
    wingType = "Traditional";
}
else
{
    wingsPrice = BOTH_WINGS;
    wingType = "Both";
}

Console.Write("What kind of sauce:\n" +
$"1. Buffalo Sauce {BUFFALO_SAUCE:C}\n" +
$"2. Mild Sauce {MILD_SAUCE:C}\n" +
$"3. BBQ Sauce {BBQ_SAUCE:C}\n" +
$"4. Plain Sauce {PLAIN_SAUCE:C}\n" +
"Enter your selection: "
);

int sauceSelection = int.Parse(Console.ReadLine());

double saucePrice = 0;
string sauceType = "";

if(sauceSelection == 1)
{
    saucePrice = BUFFALO_SAUCE;
    sauceType = "Buffalo Sauce";
}
else if(sauceSelection == 2)
{
    saucePrice = MILD_SAUCE;
    sauceType = "Mild Sauce";
}
else if(sauceSelection == 3)
{
    saucePrice = BBQ_SAUCE;
    sauceType = "BBQ Sauce";
}
else
{
    saucePrice = PLAIN_SAUCE;
    sauceType = "Plain Sauce";
}

Console.Write("Do you want a side order:\n" + 
$"1. Waffle Fries {WAFFLE_FRIES_SIDE:C}\n" +
$"2. Onion Rings {ONION_RINGS_SIDE:C}\n" +
$"3. Both {BOTH_SIDES:C}\n" +
$"4. None {NONE_SIDES:C}\n" +
"Enter your selection: "
) ;

int sideSelection = int.Parse(Console.ReadLine());

double sidePrice = 0;
string sideType = "";

if(sideSelection == 1)
{
    sidePrice = WAFFLE_FRIES_SIDE;
    sideType = "Waffle Fries";
}
else if(sideSelection == 2)
{
    sidePrice = ONION_RINGS_SIDE;
    sideType = "Onion Rings";
}
else if(sideSelection == 3)
{
    sidePrice = BOTH_SIDES;
    sideType = "Both";
}
else
{
    sidePrice = NONE_SIDES;
    sideType = "None";
}

//  Processing...
//  Check if customer ordered both types of wings, if so, do the discount calculation
double orderTypeDiscount = 0;

if(wingsSelection == 3)
{
    //  Customer has a discount, we use this variable to show how much discount the customer gets
    //  and to substract it from wings Price
    orderTypeDiscount = wingsPrice * BOTH_WINGS_DISCOUNT;
}

//  If customer has no discount, this math is okay because 0 won't impact wingsPrice
double subTotal = 0;
double tax = 0;
double total = 0;

wingsPrice -= orderTypeDiscount;

subTotal += wingsPrice;
subTotal += saucePrice;
subTotal += sidePrice;

tax = subTotal * NYS_TAX_RATE;

total = subTotal + tax;

Console.WriteLine("***RECEIPT***");
Console.WriteLine($"{wingType} {wingsPrice:C}");

//  Show discount only if we really have a discount
if(orderTypeDiscount > 0)
{
    Console.WriteLine($"Discount: {orderTypeDiscount:C}");
}

Console.WriteLine($"{sauceType}: {saucePrice:C}");
Console.WriteLine($"{sideType}: {sidePrice:C}");
Console.WriteLine($"Subtotal: {subTotal:C}");
Console.WriteLine($"Tax: {tax:C}");
Console.WriteLine($"Total: {total:C}\n");
Console.WriteLine("Thank you.");
