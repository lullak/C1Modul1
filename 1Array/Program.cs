//Skapa ett program där användaren får upp ett antal frågor där den får mata in sitt förnamn,
//efternamn, adress, postort, telefon, email. Spara alla dessa värden i en array. Skriv sedan
//tillbaka en kontrollfråga på skärmen till användaren där du läser ut alla värden från arrayenDu har matat in följande uppgifter……stämmer det?. 
string[] userInformation = new string[6];

Console.Write("Mata in ditt förnamn: ");
userInformation[0] = Console.ReadLine();
Console.Write("Mata in ditt efternamnförnamn: ");
userInformation[1] = Console.ReadLine();
Console.Write("Mata in ditt adress: ");
userInformation[2] = Console.ReadLine();
Console.Write("Mata in ditt postort: ");
userInformation[3] = Console.ReadLine();
Console.Write("Mata in ditt telefon: ");
userInformation[4] = Console.ReadLine();
Console.Write("Mata in ditt email: ");
userInformation[5] = Console.ReadLine();

for (int i = 0; i < userInformation.Length; i++)
{
    Console.WriteLine($"Stämmer det? {userInformation[i]}");
}

Console.ReadLine();