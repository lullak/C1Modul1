//Be användaren mata in sitt födelse år. Om det är större eller lika med 1980 men mindre än 
//1990 skriv ut –Du är född på 1980-talet. Om det är mindre än 2000 men större än eller lika 
//med 1990 skriv ut- Du är född på 1990-talet. Om det är mindre än 1980 eller större än eller 
//lika med 2000, skriv- Du är inte född på 1990 eller 1980-talen. 

Console.WriteLine("Mata in året du är född: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

AgeIndicator(birthYear);

Console.ReadLine();

void AgeIndicator(int birthYear)
{
    if (birthYear >= 1980 && birthYear < 1990)
        Console.WriteLine("Du är född på 1980-talet.");
    else if (birthYear >= 1990 && birthYear < 2000)
        Console.WriteLine("Du är född på 1990-talet.");
    else
        Console.WriteLine("Du är inte född på 1990 eller 1980-talen.");
}