Console.Write("Mata in antal minuter så omvandlas det till dyng,timmar och minuter. ");
int userEnteredMinutes = Convert.ToInt32(Console.ReadLine());

ConvertMinutesToDays(userEnteredMinutes);


Console.ReadLine();
void ConvertMinutesToDays(int userEnteredMinutes)
{
    int days = userEnteredMinutes / 60 / 24;
    int hours = userEnteredMinutes / 60 % 24;
    int minutes = userEnteredMinutes % 60;

    if (userEnteredMinutes < 60)
    {
        Console.WriteLine($"{userEnteredMinutes} minuter.");
    }
    else if(userEnteredMinutes >= 60 && userEnteredMinutes < 60*24)
    {
        
        Console.WriteLine($"Det är {hours} timmar och {minutes} minuter.");
    }
    else if(userEnteredMinutes >= 60*24)
    {
        
        Console.WriteLine($"Det är {days} dagar, {hours} timmar och {minutes} minuter.");
    }
}

