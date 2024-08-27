//Be användaren att mata in hur många paket mjölk som finns kvar. Är det mindre än 10 skrivBeställ 30 paket. 
//    Är det mellan 10 och 20 skriv- Beställ 20 paket. Annars skriv-Du behöver inte beställa någon mjölk. 

MilkOrder();
MilkOrder();
MilkOrder();
MilkOrder();
Console.ReadKey();
void MilkOrder()
{
    Console.Write("Hur många mjölk paket finns det kvar? ");
    int milkPack = Convert.ToInt32(Console.ReadLine());

    if (milkPack < 10)
    {
        Console.WriteLine("Beställ 30 paket");
    }
    else if (milkPack >= 10 && milkPack <= 20)
    {
        Console.WriteLine("Beställ 20 paket");
    }
    else
    {
        Console.WriteLine("Beställ inte mjölk");
    }
}