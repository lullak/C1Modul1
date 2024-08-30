//Skapa ett program där användaren måste mata in 10 tal. 
//a. Kontrollera först att användaren matar in ett giltigt tal och inte andra tecken. Använd int.TryParse metoden. Om det inte är ett tal, backa ett steg i loopen,
//meddela användaren –Du har matat in ett ogiltigt tal försök igen. 
//b. Kontrollera om värdet är mindre än 30. Om det är det skriv ned det till en array 
//c. När loopen är klar och 10 tal matats in, skriv ut alla tal som var under 30 på skärmen i  en lista. 

int[] ints = new int[10];
bool isANumber = false;

for (int i = 0; i < ints.Length; i++)
{
    while (isANumber == false) {
        
        Console.Write("Mata in ett tal: ");
        isANumber = int.TryParse(Console.ReadLine(), out int numbers);
        if (numbers < 30 && isANumber == true)
        {
            ints[i] = i;
        }
        else
        {
            Console.WriteLine("Du har matat in ett felkatigt nummer");
            isANumber = false;
        }
    }
    isANumber = false;
    
}
int numberOrder = 1;
for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine($"Tal {numberOrder+i}: {ints[i]}.");
}

Console.ReadLine();