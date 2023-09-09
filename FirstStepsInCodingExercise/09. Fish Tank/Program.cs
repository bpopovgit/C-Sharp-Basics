int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double space = length * width * height;
double spaceInLiters = space / 1000;
double occupiedSpace = percentage / 100;
double neededLiters = spaceInLiters * (1 - occupiedSpace);

Console.WriteLine(neededLiters);

