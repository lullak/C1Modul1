Moms();
Console.ReadLine();
void Moms()
{
    Console.Write("Mata in en summa: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Nya summan med moms är: {x * 1.25}");
}