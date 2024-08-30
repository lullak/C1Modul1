//Be användaren mata in en mailadress. Programmet skall kontrollera att inmatningen är rätt 
//dvs att det finns ett @ tecken och att det finns en . med 2 eller 3 tecken efter. Meddela 
//användaren om det är rätt eller felaktig adress 


Console.Write("Mata in din mejladress: ");
string mailAddress = Console.ReadLine();
int mailAddressLength = mailAddress.Length;

if (mailAddress.Contains("@"))
{
    if (mailAddress.LastIndexOf(".") == mailAddressLength - 3 || mailAddress.LastIndexOf(".") == mailAddressLength - 4)
    {
        Console.WriteLine("Korrekt mejladress");
    }
    else 
    {
        Console.WriteLine("Felaktig mejladress");
    }
}
else
{
    Console.WriteLine("Felaktig mejladress");
}

Console.ReadLine();