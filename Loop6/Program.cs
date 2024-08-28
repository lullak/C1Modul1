int tal = 0;

do
{
    Console.Write("Mata in ett tal: ");
    tal = Convert.ToInt32(Console.ReadLine());

    if (tal < 10)
        Console.WriteLine("Värdet för lågt!");
    else if (tal > 10)
        Console.WriteLine("Värdet är fär högt!");
}
while (tal != 10);

Console.WriteLine("Du matade in rätt tal!");

Console.ReadKey();