//Du har en strängvariabel som innehåller följande text, ”Hello, world” 
//a. Ta med hjälp av kod ut första förekomsten av bokstaven w 
//b. Skriv ut vilken position bostaven w har i strängen (H har position 0). Ta fram 
//positionen genom kod. 

string helloWorld = "Hello, world";
int position = helloWorld.IndexOf("w");

Console.WriteLine($"Bokstaven w har index {position}");

Console.ReadKey();