//Du har en sträng med texten ”Detta är en sträng som du skall ändra”. Ersätt via kod alla 
//blanktecken i strängen med tecknet * . Räkna sedan ut via kod hur många förekomster det 
//finns av tecknet * i strängen. 

string changeString = "Detta är en sträng som du skall ändra";
changeString = changeString.Replace(" ", "*");

// enligt facit, där man får fram antalet substings(ord) som är 8 och tar bort 1
//int amountOfStars = changeString.Split('*').Length-1;

//Console.WriteLine(amountOfStars);

// gör det till en char array som man loopar genom

char[] chars = changeString.ToCharArray();

int count = 0;
int counter = 0;
while (counter < changeString.Length)
{
    if (changeString[counter] == '*')
    {
        count++;
    }

    counter++;
}

Console.WriteLine(changeString);
Console.WriteLine(count);

Console.ReadKey();