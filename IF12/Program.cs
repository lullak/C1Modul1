//12.Skapa ett program för att ”Växla pengar”. 
//a. Låt användaren ange ett belopp som ska betalas. 
//b. Ange växel i antal 500-lappar, 100-lappar, ner till kronor. 
//c. Skriv detta till skärmen

Console.Write("Ange belopp som ska betalas: ");
int cashAmount = Convert.ToInt32(Console.ReadLine());

CurrencyExchange(cashAmount);

Console.ReadKey();

void CurrencyExchange(int cashAmount)
{
    int femhundraLappar = 0;
    int hundraLappar = 0;
    int kronor = 0;

    if (cashAmount < 100)
    {
        
        Console.WriteLine($"Växel blir {cashAmount}");
    }
    else if (cashAmount >= 100 && cashAmount < 500)
    {
        hundraLappar = cashAmount / 100;
        kronor = cashAmount - (hundraLappar * 100);
        Console.WriteLine($"Växeln blir {hundraLappar} hundralappar och {kronor} kronor.");
    }
    else
    {
        femhundraLappar = cashAmount / 500;
        kronor = cashAmount - (femhundraLappar * 500);
        hundraLappar = kronor / 100;
        kronor = kronor - (hundraLappar * 100);

        Console.WriteLine($"Växeln blir {femhundraLappar} femhundralappar, {hundraLappar} hundralappar och {kronor} kronor.");
    }
}
