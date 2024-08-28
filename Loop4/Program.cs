int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Mata in ett tal: ");
    int tal = Convert.ToInt32(Console.ReadLine());
    sum += tal;
}

Console.WriteLine($"Summa: {sum}");

Console.ReadLine();