AddTwoNumbers();
Console.ReadLine();
void AddTwoNumbers()
{
    Console.Write("Mata in första talet för att addera: ");
    int x = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Mata in första talet för att addera: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Summan av {x} och {y} är: {x+y}");
}