MinutesToHours();
Console.ReadLine();
void MinutesToHours()
{
    
    int minuter;
    do
    {
        Console.Write("Mata in ett antal minuter (minst 60 minuter): ");
        minuter = Convert.ToInt32(Console.ReadLine());
    }
    while (minuter <= 60);

    Console.WriteLine($"Detta är {minuter / 60} timmar och {minuter % 60} minuter.");
}