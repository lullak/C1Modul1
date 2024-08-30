//Skapa ett program där användaren får mata in en inköpslista. Börja med att fråga 
//användaren hur många varor den skall ha på sin lista. Gör en loop som gås igenom det antal 
//gånger som användaren angivit. Inne i loopen skall tre frågor anges- Vilken vara som 
//användaren vill lägga till- Vilket pris varan har – Vilket produktnummer. Spara alla dessa 
//värden i en array. Loopa sedan igenom arrayen och skriv ut alla varor som användaren har 
//angivit med alla uppgifter på skärmen. 


Console.Write("Hur många varor ska du ha på din lista? ");
int countGoods = int.Parse(Console.ReadLine());

string[,] goodsList = new string[countGoods,3];
int counter = 0;

while (counter < countGoods)
{

    
    Console.Write("Vilken vara vill du lägga till? ");
    goodsList[counter, 0] = Console.ReadLine();
    Console.Write("Vilket pris har varan? ");
    goodsList[counter, 1] = Console.ReadLine();
    Console.Write("Vilket produktnummer har varan? ");
    goodsList[counter, 2] = Console.ReadLine();




    counter++;
}

for (int i = 0; i < goodsList.GetLength(0); i++)
{
    Console.WriteLine($"Vara: {goodsList[i, 0]}, pris: {goodsList[i, 1]} och produktnummer: {goodsList[i, 2]}.");
}

//foreach (var item in goodsList)
//{
//    Console.WriteLine(item);
//}

Console.ReadLine();

//(string, int, int)[,] goodsList = new (string, int, int)[countGoods, 3];

//for (int i = 0; int i < length; int i++)
//    {
//        Console.Write("Vilken vara ska läggas till? ");
//string productName = Console.ReadLine();
//Console.Write("Vilket pris har varan? ");
//int productPrice = int.Parse(Console.ReadLine());
//Console.Write("Vilket produktnummer har varan? ");
//int productNumber = int.Parse(Console.ReadLine());
//    }