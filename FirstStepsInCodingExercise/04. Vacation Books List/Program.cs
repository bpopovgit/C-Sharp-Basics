int numberOfPagesInBook = int.Parse(Console.ReadLine());
int numberOfPagesReadPerHour = int.Parse(Console.ReadLine());
int numberOfDaysToReadTheBook = int.Parse(Console.ReadLine());
int totalTimeNeededPerBook = numberOfPagesInBook / numberOfPagesReadPerHour;
int totalHoursNeeded = totalTimeNeededPerBook / numberOfDaysToReadTheBook;
Console.WriteLine(totalHoursNeeded);