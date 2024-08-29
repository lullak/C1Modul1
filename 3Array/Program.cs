//Utöka uppgift 2 med en inledande fråga där användaren får ange hur många tal den vill mata
//in. Gör sedan samma sak för att ta fram det största talet. 
Console.Write("Hur många tal vill du lägga in i arrayen? ");
int numberOfNumbers = Convert.ToInt32(Console.ReadLine());
int[] siffror = new int[numberOfNumbers];

for (int i = 0; i < siffror.Length; i++)
{
    Console.Write("Mata in ett tal: ");
    siffror[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(siffror);

Console.WriteLine($"Största talet är: {siffror[numberOfNumbers-1]}");
Console.ReadKey();