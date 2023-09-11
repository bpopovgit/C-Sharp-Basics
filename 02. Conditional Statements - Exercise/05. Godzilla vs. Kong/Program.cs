double budget = double.Parse(Console.ReadLine());
int extrasCount =  int.Parse(Console.ReadLine());
double extraClothsPrice = double.Parse(Console.ReadLine());


double decorPrice = budget * 0.1;
double totalExtraCosts = extrasCount * extraClothsPrice;
double discount = 0;

if (extrasCount > 150)
{
    discount = totalExtraCosts * 0.1;
}

double finalClothingSum = totalExtraCosts - discount;

double totalPrice = decorPrice + finalClothingSum;

double difference = Math.Abs(budget - totalPrice);

if (budget >= totalPrice)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {difference:f2} leva more.");
}
