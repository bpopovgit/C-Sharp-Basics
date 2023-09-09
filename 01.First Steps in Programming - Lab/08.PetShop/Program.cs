int dogFoodWrapping = int.Parse(Console.ReadLine());
int catFoodWrapping = int.Parse(Console.ReadLine());
double moneyNeededForDogFood = dogFoodWrapping * 2.50;
double moneyNeededForCatFood = catFoodWrapping * 4.00;
double final_price = moneyNeededForDogFood + moneyNeededForCatFood;
Console.WriteLine(final_price + " lv.");

