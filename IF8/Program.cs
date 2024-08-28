//Be användaren att mata in namnet på ett land där den bor. Om det är Sverige, Danmark,
//eller Norge skall användare informeras att-Du bor i Skandinavien. Om inte meddela 
//användaren att den inte bor i Skandinavien. 

Console.Write("Mata in det land du bor i: ");
string userCountryOfResidence = Console.ReadLine().ToLower();

if (userCountryOfResidence == "sverige" || userCountryOfResidence == "danmark" || userCountryOfResidence == "norge")
    Console.WriteLine("Du bor i skandinavien.");
else 
    Console.WriteLine("Du bor inte i skandinvaien");

Console.Read();