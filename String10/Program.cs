Console.WriteLine("Mata in ett ord eller mening, så kikar programmet på om det är en palindrom. ");
string inputString = Console.ReadLine().ToLower();
inputString = inputString.Replace(" ", "");

//string reversedInputString = inputString.Reverse().ToString();

//char[] inputToChars = inputString.ToCharArray();
//char[] reversedInput = inputToChars.Reverse().ToArray();


//string originalString = new string(inputToChars);
//string reversedString = new string(reversedInput);

//if (originalString == reversedString)
//{
//    Console.WriteLine($"Orden {originalString} och {reversedString} är en Palindrom");
//}
//else
//{
//    Console.WriteLine($"Orden {originalString} och {reversedString} är inte en Palindrom");
//}

//For loop för att lägga in orden i en array baklänges
string reverseString = "";
for (int i = inputString.Length - 1; i >= 0; i--)
{
    reverseString = reverseString + inputString[i].ToString();
}

if (inputString == reverseString)
{
    Console.WriteLine($"Orden {inputString} och {reverseString} är en Palindrom");
}
else
{
    Console.WriteLine($"Orden {inputString} och {reverseString} är inte en Palindrom");
}


Console.ReadLine();