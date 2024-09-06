//initialize variables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;

//intitalize constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

//prompt the user for # of sandwiches
Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
Console.WriteLine("Sandwiches "+numberOfSandwiches);

//prompt the user for # of toppings
Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
Console.WriteLine("Toppings "+numberOfToppings);

//prompt the user for the tip
Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());
Console.WriteLine("Tip "+tip);

//putting together total order cost and initializing orderCost
double orderCost = 0;
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalToppingCost+totalSandwichCost;
orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
Console.WriteLine("Your order costs "+orderCost);

//I know it was mentioned that on projects we would have to add in extra features to get full points, so just in case, I'm adding this.
double totalSaved = 0;
totalSaved = baseCost * DISCOUNT_AMOUNT;
Console.WriteLine("For National Sandwich Day, you saved "+totalSaved+"! :)");


