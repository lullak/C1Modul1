Console.Write("Mata in ett tal: ");
bool success = false;

do
{
    
    success = int.TryParse(Console.ReadLine(), out int tal);

    if (tal >= 30 || success == false)
    {
        Console.Write("Du har matat in fel, försök igen: ");
        success = false;
    }
    else
    {
        for (int i = tal +1; i <= 30; i++)
        {
            
            Console.WriteLine(i);
        }
    }
}
while (success != true);

Console.ReadKey();