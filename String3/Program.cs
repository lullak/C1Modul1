//Du har en strängvariabel som ser ut så här string b ="I am a C# hacker." 
//a. Skriv ut vilken position sista a har 
//b. Skriv ut i vilken position ”C” har i strängen ovan. Skriv samtidigt ut längden på 
//hela strängen ovan 
//c. Skriv ut varje ord för sig under varandra i en skärmutskrift 
//d. Plocka ut delsträngen ' hacker' ur b ovan via kod och skriv på skärmen 
//e. Gör om strängen b så att den ser ut så här:" i Am A C# hAcKeR"

//ab
//string b = "I am a C# hacker.";
//int lastPositionA = b.LastIndexOf("a");
//int firstPositionC = b.LastIndexOf("C");

//Console.WriteLine($"Sista a har position: {lastPositionA},C har position: {firstPositionC}, strängen är {b.Length} tecken lång.");


//c
//foreach (var words in b)
//{
//    Console.WriteLine(words);
//}

//d
//string b = "I am a C# hacker.";
//string pickOutHacker = b.Substring(10,6);

//Console.WriteLine(pickOutHacker);

//string b = "I am a C# hacker.";
//string subString = "hacker";
//int positionHacker = b.IndexOf(subString);
//string choosenWord = b.Substring(positionHacker, subString.Length);

//Console.WriteLine(choosenWord);

//e
//konvertering till char
//string b = "I am a C# hacker.";
//char[] bArray = b.ToCharArray();

//bArray = Array.ConvertAll(bArray, w => w switch
//{
//    'a' => 'A',
//    'I' => 'i',
//    'k' => 'K',
//    '.' => ' ',
//    'r' => 'R',
//    _ => w  // Default case: keep the character unchanged
//});

//for (int i = 0; i < bArray.Length; i++)
//{
//    if (bArray[i] == 'a')
//    {
//        bArray[i] = 'A';
//    }
//    else if(bArray[i] == 'I')
//    {
//        bArray[i] = 'i';
//    }
//    else if (bArray[i] == 'k')
//    {
//        bArray[i] = 'K';
//    }
//    else if (bArray[i] == '.')
//    {
//        bArray[i] = ' ';
//    }
//    else if (bArray[i] == 'r')
//    {
//        bArray[i] = 'R';
//    }
//}

//Console.WriteLine(bArray);

//replace method
string b = "I am a C# hacker.";
b = b.Replace("a", "A");
b = b.Replace("I", "i");
b = b.Replace("k", "K");
b = b.Replace("r", "R");
b = b.Replace(".", "");

Console.WriteLine(b);




Console.ReadKey();