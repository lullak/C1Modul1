TwoNumbers();
Console.ReadLine();
void TwoNumbers()
{
    Console.Write("Mata in tal 1: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Mata in tal 2: ");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Summan av {x} och {y} är: {x + y}");
    Console.WriteLine($"Medelvärdet av {x} och {y} är: {(x + y) / 2}");
    Console.WriteLine($"Differensen av {x} och {y} är: {x - y}");
}