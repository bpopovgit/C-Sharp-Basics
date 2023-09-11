double vacationPrice = double.Parse(Console.ReadLine());
int numberOfPuzzles = int.Parse(Console.ReadLine());
int numberOfTalkingDolls = int.Parse(Console.ReadLine());
int numberOfPlushBears = int.Parse(Console.ReadLine());
int numberOfMinions = int.Parse(Console.ReadLine());
int numberOfCarToys = int.Parse(Console.ReadLine());

double puzzlesPrice = numberOfPuzzles * 2.60;
double talkingDollsPrice = numberOfTalkingDolls * 3.00;
double plushBearsPrice = numberOfPlushBears * 4.10;
double minionsPrice = numberOfMinions * 8.20;
double carToysPrice = numberOfCarToys * 2.00;

double finalPrice = puzzlesPrice + talkingDollsPrice + plushBearsPrice + minionsPrice + carToysPrice;

int toysCount = numberOfPuzzles + numberOfTalkingDolls + numberOfPlushBears + numberOfMinions + numberOfCarToys;

if (toysCount >= 50)
{
    finalPrice -= finalPrice * 0.25;
}

double rentPrice = finalPrice * 0.10;
finalPrice = finalPrice - rentPrice;

double difference = Math.Abs(finalPrice - vacationPrice);

if (finalPrice >= vacationPrice)
{
    Console.WriteLine($"Yes! {difference:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
}

