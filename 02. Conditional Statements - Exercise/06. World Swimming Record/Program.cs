double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

double timeNeeded = distanceInMeters * timeInSecondsForOneMeter;
double addedTime = Math.Floor(distanceInMeters / 15);
double totalTimeNeeded = timeNeeded + addedTime * 12.5;

double difference = Math.Abs(recordInSeconds - totalTimeNeeded);

if (totalTimeNeeded > recordInSeconds)
{
    Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeNeeded:f2}");
}