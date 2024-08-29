// Detta är ett värde(tal)
int number = 0;
//Här kan vi lagra flera tal vi väljer 4
int[] numbers = new int[4];

//Peka på positionen där värdet ska in, där värdet ska hamna tilldelar man ett värde
numbers[0] = 11;
numbers[1] = 2;
numbers[2] = 30;
numbers[3] = 20;

int sum = 0;
// Ta ut värden från arrayen görs oftast i loop
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

// finns en färdig funktion för summa i en array

Console.WriteLine($"Inbyggd funktion för summa: {numbers.Sum()}");
Console.WriteLine(sum);


Console.ReadKey();