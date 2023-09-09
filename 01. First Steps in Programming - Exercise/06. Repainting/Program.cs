int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hoursNeededForTheJob = int.Parse(Console.ReadLine());

double priceForNylon = (nylonNeeded + 2) * 1.50;
double priceForPaint = (paintNeeded + paintNeeded * 0.1) * 14.50;
double priceForThinner = thinner * 5.00;
double priceForBags = 0.40;

double materialsSum = priceForNylon + priceForPaint + priceForThinner + priceForBags;

double workersSum = (materialsSum * 0.3) * hoursNeededForTheJob;

double finalPrice = materialsSum + workersSum;

Console.WriteLine(finalPrice);