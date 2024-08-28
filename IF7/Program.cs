//Skapa en inloggning där användaren först får ange användarnamn och sedan lösenord. Ange 
//det som du anser vara riktiga uppgifter i två konstanter i koden. Kontrollera sedan om det är 
//riktigt inmatat och meddela användare om den antingen är inloggad eller matat in fel 
//lösenord eller fel användarnamn 




UserPasswordChecker();

Console.ReadKey();
void UserPasswordChecker()
{
    const string validUserName = "Lullak";
    const string validPassword = "abc123";

    for (int i = 1; i <= 3; i++)
    {
        Console.Write("Ange användarnamn:");
        string userName = Console.ReadLine();
        Console.Write("Ange lösenord:");
        string userPassword = Console.ReadLine();
        if (userName == validUserName && userPassword == validPassword)
        {
            Console.WriteLine("Inloggning lyckades.");
            break;
        }
        else
        {
            Console.WriteLine($"Inloggning misslyckades, {3 - i} försök kvar.");
            Console.WriteLine();
            
            if (i == 3)
            {
                Console.WriteLine("Försök igen om 30 minuter eller försök återställa lösenord.");
            }
        }
    }
}