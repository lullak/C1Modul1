//Skapa en Console application . Be användaren mata in sitt födelsedatum. Applikationen skall 
//räkna ut hur gammal användaren är och skriva detta tillbaka till skärmen. Använd 
//DateTime.Now för beräkningen. Skriv även ut vilken år, månad och dag användaren är född 
//tex ”Du är 32 år gammal och ditt födelseår är 1989 och månaden är 2 och dagen 12”. Gör 
//detta genom att använda funktionalitet som finns kopplad till datum typen (.Year och .Month och .Day) 






Console.WriteLine("Ange födelsedatum: ");
DateTime birthDay = DateTime.Parse(Console.ReadLine());
DateTime todaysDate = DateTime.Now;

int userAge = todaysDate.Year - birthDay.Year;
if(birthDay > todaysDate.AddYears(-userAge))
{
    userAge--;
}


Console.WriteLine(userAge);
Console.WriteLine($"Du är {userAge} och ditt födelseår är {birthDay:yyyy}, månaden är {birthDay:MMMM} och dagen {birthDay:dd}.");

Console.ReadKey();