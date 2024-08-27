

BiggerThenTen();
Console.ReadLine();

void BiggerThenTen()
{
    Console.Write("Mata in ett tal: ");
    int tal = Convert.ToInt32(Console.ReadLine());
    string king = (tal > 10) ? "Siffran är större än 10" : "Siffran är lägre än 10";
    Console.WriteLine(king);}