//Skapa ett program där användaren skall mata in kontaktuppgifter. Ta emot alla värden i 
//variabler 
//a. Be användaren mata in sitt namn. 
//b. Be användaren mata in sin gatuadress 
//c. Be användaren mata in sitt postnummer 
//d. Be användaren mata in sin postort 
//e. Fråga om användaren vill mata in en ny person(J/N) 
//f. Om J återupprepa steg a-e. Detta kan göras max 5 gånger. 
//g. Svarar användaren N eller om 5 personer matats in- skriv ut alla personers uppgifter 
//på skärmen. 

string[,] userContactInformation = new string[5,4];

int counter = 0;
string userAnswer = null;

//while (true)
//{
//    Console.Write("Mata in ditt användarnamn: ");
//    userContactInformation[counter, 0] = Console.ReadLine();
//    Console.Write("Mata in din gatuadress: ");
//    userContactInformation[counter, 1] = Console.ReadLine();
//    Console.Write("Mata in ditt postnummer: ");
//    userContactInformation[counter, 2] = Console.ReadLine();
//    Console.Write("Mata in din postort: ");
//    userContactInformation[counter, 3] = Console.ReadLine();

//    if (counter == 4)
//    {
//        break;
//    }

//    Console.WriteLine("Vill du lägga till en användare? J/N");
//    userAnswer = Console.ReadLine().ToLower();
//    if (userAnswer != "j")
//    {
//        break;
//    }

//    counter++;
//}

for (int i = 0; i < userContactInformation.GetLength(0); i++)
{
    Console.Write("Mata in ditt användarnamn: ");
    userContactInformation[i, 0] = Console.ReadLine();
    Console.Write("Mata in din gatuadress: ");
    userContactInformation[i, 1] = Console.ReadLine();
    Console.Write("Mata in ditt postnummer: ");
    userContactInformation[i, 2] = Console.ReadLine();
    Console.Write("Mata in din postort: ");
    userContactInformation[i, 3] = Console.ReadLine();

    if (i == 4)
    {
        break;
    }

    Console.WriteLine("Vill du lägga till en användare? J/N");
    userAnswer = Console.ReadLine().ToLower();
    if (userAnswer != "j")
    {
        break;
    }
}

for (int i = 0; i < userContactInformation.GetLength(0); i++)
{
    if(userContactInformation[i, 0] != null)
    {
        Console.WriteLine($"Användarnamn: {userContactInformation[i, 0]}, Gatuadress: {userContactInformation[i, 1]}, Postnummer: {userContactInformation[i, 2]}, Postort: {userContactInformation[i, 3]}.");
    }
    
}

Console.ReadKey();

