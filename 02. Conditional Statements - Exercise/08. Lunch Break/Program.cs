string seriesName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());

double timeForLunch = (double)breakLength / 8;
double timeforRest = (double)breakLength / 4;

double total_time_left = breakLength - (timeForLunch + timeforRest);

double difference = Math.Abs(episodeLength - total_time_left);

if (total_time_left >= episodeLength)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(difference)} more minutes.");
}
