double depositAmount = double.Parse(Console.ReadLine());
int deadline = int.Parse(Console.ReadLine());
double yearlyDiscountRate = double.Parse(Console.ReadLine());
double yearlyInterest = depositAmount * yearlyDiscountRate / 100;
double finalAmount = depositAmount + deadline * ((yearlyInterest) / 12);
Console.WriteLine(finalAmount);
