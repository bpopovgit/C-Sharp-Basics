double budget = double.Parse(Console.ReadLine());
int graphicsCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

double graphicsCardsPrice = graphicsCardsCount * 250;
double processorsPrice = (double)graphicsCardsPrice * 0.35;
double totalProcessorsPrice = processorsCount * processorsPrice;
double ramCountPrice = (double)graphicsCardsPrice * 0.10;
double totalRamPrice = ramCount * ramCountPrice;

double finalSum = graphicsCardsPrice + totalProcessorsPrice + totalRamPrice;
double discount = 0;

if  (graphicsCardsCount > processorsCount)
{
    discount = finalSum * 0.15;
}

finalSum = finalSum - discount;

double difference = Math.Abs(finalSum - budget);

if (budget >= finalSum)
{
    Console.WriteLine($"You have {difference:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
}