int penPackets = int.Parse(Console.ReadLine());

int markerPackets = int.Parse(Console.ReadLine());

int litersDetergent = int.Parse(Console.ReadLine());

int discount = int.Parse(Console.ReadLine());

double priceForPenPackets = penPackets * 5.80;

double priceForMarkerPackets = markerPackets * 7.20;

double priceForDetergent = litersDetergent * 1.20;

double priceForAllProducts = priceForPenPackets + priceForMarkerPackets + priceForDetergent;

double totalPriceWithDiscount = priceForAllProducts - (priceForAllProducts * discount / 100);

Console.WriteLine(totalPriceWithDiscount);