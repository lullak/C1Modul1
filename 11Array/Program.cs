//Skapa ett program där användaren skriver in ett tal. Spara alla felaktiga inmatningar i en array. 
//a. Skriv mata in ett tal på skärmen 
//b. Om det är högre än 10 får användaren ett meddelande som säger-Värdet är för högt. Visa meddelandet- Mata in ett tal på skärmen. 
//c. Om det är under 10 får användaren ett meddelande som säger-Värdet är för lågt . 
//Visa meddelandet- Mata in ett tal på skärmen. 
//d. När användaren matar in 10 avbryts loopen och användaren får meddelandet – Du 
//matade in rätt tal. 
//e. Visa sedan alla tal som matats in innan användaren angav rätt tal. Skriv ut dessa i en lista.
//f. Programmet avbryts.

int[] numbers = new int[10];


for (int i = 0; i < numbers.Length; i++)
{
    
    Console.Write("Mata in ett tal: ");
    numbers[i] = int.Parse(Console.ReadLine());

    if (numbers[i] > 10)
    {
        Console.WriteLine("Du matade in för högt värde");
    }
    else if (numbers[i] < 10) {
        Console.WriteLine("Du matade in för lågt värde");
    }
    else
    {
        Console.WriteLine("Du matade in rätt tal!");
        break;
    }

    if (i == numbers.Length - 1)
    {
        Console.WriteLine("Du har inga fler försök kvar!");
    }
}

foreach (int number in numbers)
{
    
        Console.WriteLine(number);
    
}
Console.ReadKey();