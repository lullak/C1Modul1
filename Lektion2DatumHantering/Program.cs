//Skapa en lösning där användaren får mata in ett startdatum och ett slutdatum


//Kontrollera sedan följande när det gäller de datum som matats in:

//1.Slutdatum får inte vara innan startdatum
//2. Varken slut- eller startdatum får vara innan dagens datum
//3. Slutdatum kan inte vara senare än 30 dagar efter startdatum
//4. Start och slutdatum får inte vara samma datum

//Meddela användaren om det blir fel och tala om vad som inte är rätt annars skall användaren få ett meddelande om att det är riktiga datum
//Kallas för validering. Mycket vanligt när man har data som matas in via någon form av formulär

Console.Write("Ange startdatum: ");
DateTime startDate = DateTime.Parse(Console.ReadLine());

Console.Write("Ange slutdatum: ");
DateTime endDate = DateTime.Parse(Console.ReadLine());



if (startDate > endDate)
{
    Console.WriteLine("Slutdatum får inte vara innan startdatum");
}
else if (DateTime.Now.Date > endDate || DateTime.Now.Date > startDate)
{
    Console.WriteLine("Varken slut- eller startdatum får vara innan dagens datum");
}
else if(endDate > startDate.AddDays(30))
{
    Console.WriteLine("Slutdatum kan inte vara senare än 30 dagar efter startdatum");
}
else if(startDate.Date == endDate.Date)
{
    Console.WriteLine("Start och slutdatum får inte vara samma datum");
}
else
{

}

Console.ReadKey();