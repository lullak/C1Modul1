string userName = "";
string userAddress = "";
string userPostalCode = "";
string userCity = "";
do
{
    if (userName == "")
    {
        Console.Write("Ange namn: ");
        userName = Console.ReadLine();
    }
    if (userAddress == "")
    {
        Console.Write("Ange adress: ");
        userAddress = Console.ReadLine();
    }
    if (userPostalCode == "") 
    {
        Console.Write("Ange postkod: ");
        userPostalCode = Console.ReadLine();
    }
    if (userCity == "")
    {
        Console.Write("Ange ort: ");
        userCity = Console.ReadLine();
    }
    if(userName != "" && userAddress != "" && userPostalCode != "" && userCity != "")
        break;
    
}
while (true);

Console.WriteLine($"{userName}\n{userAddress}\n{userPostalCode}\n{userCity}");

Console.ReadKey();