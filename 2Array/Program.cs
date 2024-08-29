//Skapa ett program där användaren får upp fyra frågor om att mata in ett tal. Spara alla talen i
//en array. Loopa igenom arrayen och ta fram det tal som är störst. Skriv tillbaka resultatet på
//skärmen för användaren. 

int[] siffror = new int[4];

for (int i = 0; i < siffror.Length; i++)
{
    Console.Write("Mata in ett tal: ");
    siffror[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(siffror);

Console.WriteLine($"Största talet är: {siffror[3]}");
Console.ReadKey();