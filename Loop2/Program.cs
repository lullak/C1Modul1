Console.Write("Mata in tal1: ");
int tal1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Mata in tal2: ");
int tal2 = Convert.ToInt32(Console.ReadLine());

for(int i = tal1 + 1; i < tal2; i++)
{
    Console.WriteLine(i);
}

Console.ReadKey();