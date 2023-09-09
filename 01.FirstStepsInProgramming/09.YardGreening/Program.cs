double cubicMeters = double.Parse(Console.ReadLine());
double initialPrice = cubicMeters * 7.61;
double discount = initialPrice * 0.18;
double finalPrice = initialPrice - discount;
Console.WriteLine("The final price is: " + finalPrice + " lv.");
Console.WriteLine("The discount is: " + discount + " lv.");