//Fortsätt med uppgift 4. Du skall nu skriva ut exakt hur stor skillnad det är mellan de två 
//datumen i antal dagar tex ”Datum 1 är 10 dagar senare än datum 2”

DateTime dateTime1 = InputDateTime("Mata in datum ett: ");
DateTime dateTime2 = InputDateTime("Mata in datum två: ");

int dateCompare = DateTime.Compare(dateTime1, dateTime2);

//enligt facit
TimeSpan difference = dateTime1 - dateTime2;

if (dateCompare > 0) 
{
    Console.WriteLine($"Datum {dateTime1:yyyy-MM-dd} är senare än {dateTime2:yyyy-MM-dd}");
    Console.WriteLine($"Det skiljer sig {dateTime1 - dateTime2:dd} dagar ");
    //enligt facit
    Console.WriteLine($"Första datumet är {difference.Days} dagar större");
}

else if (dateCompare < 0)
{ 
    Console.WriteLine($"Datum {dateTime2:yyyy-MM-dd} är senare än {dateTime1:yyyy-MM-dd}");
    Console.WriteLine($"Det skiljer sig {dateTime2 - dateTime1:dd} dagar");
    //enligt facit
    Console.WriteLine($"Första datumet är {difference.Days *-1} dagar större");
}
else
{
    Console.WriteLine("Det är samma datum");
}

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
