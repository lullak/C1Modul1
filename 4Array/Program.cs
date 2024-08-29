//Skapa en array av 5 heltal och fyll den med värden. Byt ut alla udda tal i arrayen mot talet 0.
//Skriv sedan efteråt ut innehållet i hela arrayen till skärmen. 

int[] ints = {3, 134, 23, 35, 435, 565};

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] % 2 != 0)
    {
        ints[i] = 0;
    }
}

foreach (int siffror in ints)
{
    Console.WriteLine($"{siffror}");
}
//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"{ints[i]}");
//}

Console.ReadKey();