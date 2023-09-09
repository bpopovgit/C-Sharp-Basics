int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double priceForChickenMenu = chickenMenu * 10.35;
double priceForFishMenu = fishMenu * 12.40;
double priceForVegetarianMenu = vegetarianMenu * 8.15;
double menusTotalPrice = priceForChickenMenu + priceForFishMenu + priceForVegetarianMenu;
double dessertPrice = menusTotalPrice * 0.20;
double deliveryPrice = 2.50;
double totalCost = menusTotalPrice + dessertPrice + deliveryPrice;
Console.WriteLine(totalCost);