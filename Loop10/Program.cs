
//c. Skriv ett meddelande till användaren och be denne att ange användarnamn 
//d. Skriv ett meddelande till användaren och be denne att ange lösenord 
//e. Om användaren anger ett riktigt användarnamn och lösenord, visa ett meddelande 
//som säger- Du är inloggad. Avsluta programmet. 
//f. Om användaren anger felaktiga uppgifter , skriv ett meddelande på skärmen och tala 
//om vad som var felaktigt. Fråga om användaren vill försöka igen(J/N) 
//g. Svarar användaren J, återupprepa punktc-d 


UserLogin();
Console.ReadKey();

void UserLogin()
{
    const string userName = "testkonto";
    const string userPassword = "abc123";
    string userInputName;
    string userInputPassword;

    while (true)
    {
        userInputName = "";
        userInputPassword = "";
        Console.Write("Ange användarnamn: ");
        userInputName = Console.ReadLine();
        Console.Write("Ange Lösenord: ");
        userInputPassword = Console.ReadLine();

        if (userName == userInputName && userPassword == userInputPassword)
        {
            Console.WriteLine("Grattis du är inloggad");
            break;
        }
        else
        {
            string userAnswer = "";
            if (userName != userInputName)
            {
                Console.Write("Felaktig användarnamn, vill du försöka igen? J/N? ");
                userAnswer = Console.ReadLine().ToLower();
            }
            else if (userPassword != userInputPassword)
            {
                Console.Write("Felaktig lösenord, vill du försöka igen? J/N? ");
                userAnswer = Console.ReadLine().ToLower();
            }
            if (userAnswer != "j")
            {
                break;
            }
        }
        
    }
}