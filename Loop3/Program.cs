string answer = "";
do
{
    Console.Write("Mata in tal1: ");
    int tal1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Mata in tal2: ");
    int tal2 = Convert.ToInt32(Console.ReadLine());

    int sum = tal1 + tal2;

    Console.WriteLine($"Summan av {tal1} och {tal2} är {sum}");

    Console.WriteLine("Vill du fortsätta? J/N");
    answer = Console.ReadLine().ToLower();
}
while (answer == "j");

