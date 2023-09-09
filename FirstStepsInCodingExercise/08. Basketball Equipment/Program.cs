int yearlyTaxForBasketballTraining = int.Parse(Console.ReadLine());
double shoesPrice = yearlyTaxForBasketballTraining - (double)yearlyTaxForBasketballTraining * 40 / 100;
double equipmentPrice = shoesPrice - (shoesPrice * 20 / 100);
double ballPrice = equipmentPrice / 4;
double accessoriesPrice = ballPrice / 5;

double total_price = yearlyTaxForBasketballTraining + shoesPrice + equipmentPrice + ballPrice + accessoriesPrice;
Console.WriteLine(total_price);