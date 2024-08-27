FeverTemperature();

Console.ReadLine();
void FeverTemperature()
{
    Console.Write("Mata in temperaturen: ");
    double bodyTemperature = Convert.ToDouble(Console.ReadLine());

    if (bodyTemperature > 39.5)
    {
        Console.WriteLine("Du bör uppsöka en läkare.");
    }
    else if (bodyTemperature > 37.8)
    {
        Console.WriteLine("Du har feber.");
    }
    else {
        Console.WriteLine("Du har inte feber.");
    }
}