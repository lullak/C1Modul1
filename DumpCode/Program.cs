//Övningarna går ut på att studenterna skall träna på att läsa kod och därefter beskriva vad de kommit
//fram till.
//- Läs koden individuellt och skriv ned ditt resultat (5 min)
//- I grupper på 3 studenter, förklara för de andra hur du kommit fram till resultatet (10 min)
//- Vi avrundar med att gå igenom lösningen tillsammans på tavlan
// Vad blir resultatet av följande kod, vad skrivs ut ? 



bool iAmHockeyPlayer;
bool iAmSoccerPlayer;
bool isWinter = false;

iAmHockeyPlayer = true;
iAmSoccerPlayer = false;
if (isWinter != true) // is vinter är false koden körs
{
    iAmSoccerPlayer = true; //sätts till true
}

if (iAmSoccerPlayer == true) // condition stämmer
{
    Console.WriteLine("Soccer"); // skrivs ut
}
else if (iAmHockeyPlayer)
{
    Console.WriteLine("Hockey");
}
else
{
    Console.WriteLine("Neither");
}