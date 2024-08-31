//Skapa en Console application . Be användaren mata in två datum. Applikationen skall via kod 
//jämföra dessa datum och meddela vilket av datumen som är senast i tid tex ”Datum 1 är ett 
//senare datum än datum 2 ”

DateTime dateTime1 = InputDateTime("Mata in datum ett: ");
DateTime dateTime2 = InputDateTime("Mata in datum två: ");

int dateCompare = DateTime.Compare(dateTime1, dateTime2);

if (dateCompare > 0)
    Console.WriteLine($"Datum {dateTime1:yyyy-MM-dd} är senare än {dateTime2:yyyy-MM-dd}");
else if (dateCompare < 0)
    Console.WriteLine($"Datum {dateTime2:yyyy-MM-dd} är senare än {dateTime1:yyyy-MM-dd}");
else
    Console.WriteLine("Det är samma datum");

DateTime InputDateTime(string text)
{
    DateTime dateTime;
    while (true)
    {
        Console.WriteLine(text);
        if (!DateTime.TryParse(Console.ReadLine(), out dateTime))
        {
            Console.WriteLine("Datumen har angivits i fel format.");
        }
        else
        {
            break;
        }
    }
    return dateTime;
}


Console.ReadKey();
