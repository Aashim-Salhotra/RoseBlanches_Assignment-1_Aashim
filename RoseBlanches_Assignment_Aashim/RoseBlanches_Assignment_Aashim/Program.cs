//taking the input:
Console.Write("How much money did you receive?: $");
double moneyReceived = double.Parse(Console.ReadLine());

//variables:
double booksAndSupplies = moneyReceived * 0.75;
double moneyLeft = moneyReceived - booksAndSupplies;
int coffees = (int)(moneyLeft / 2);
int flashComputer = (int)(moneyLeft / 4);
int subwayTickets = (int)(moneyLeft / 3);
double totalCost = (coffees * 2) + (flashComputer * 4) + (subwayTickets * 3);

//calculating:
while (totalCost > moneyLeft)
{
coffees--;
flashComputer--;
subwayTickets--;
totalCost = (coffees * 2) + (flashComputer * 4) + (subwayTickets * 3);
}
double whiteRoses = moneyLeft - totalCost;

//printing the output:
Console.WriteLine("Book and Supplies: " + booksAndSupplies);
Console.WriteLine($"You can then buy:");
Console.WriteLine(coffees +" coffees");
Console.WriteLine(flashComputer +" Flash Computer Numbers");
Console.WriteLine(subwayTickets +" subway Tickets");
Console.WriteLine("And you will have " + whiteRoses +" for the white roses.");
 