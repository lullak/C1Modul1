//Övning – Läsa och tolka kod (loopar)
//Övningarna går ut på att studenterna skall träna på att läsa kod och därefter beskriva vad de kommit
//fram till.
//- Läs koden individuellt och skriv ned ditt resultat (5 min)
//- I grupper på 3 studenter, förklara för de andra hur du kommit fram till resultatet (10 min)
//- Vi avrundar med att gå igenom lösningen tillsammans på tavlan
// Vad blir resultatet av följande kod, vad skrivs ut ?

int resultat = 0;
int counter = 0;
while (counter < 4)
{
    for (int i = 0; i < 5; i++)
    {
        resultat = resultat + 1;
    }
    counter++;
}
Console.WriteLine(resultat);

