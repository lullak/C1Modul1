//10.Be användaren mata in en summa på hur mycket pengar den har. Be sedan användaren att 
//ange om den har rabatt. Spara i variabler. 
//a. Om summan är mellan 15 och 25 och användaren inte har rabatt skriv – Du kan köpa 
//en liten hamburgare. 
//b. Om summan är mellan 15 och 25 och användaren har rabatt skriv – Du kan köpa en 
//liten hamburgare och en pommes frites. 
//c. Om summan är större än 25 och mindre än eller lika med 50 och användaren inte 
//har rabatt skriv – Du kan köpa en stor hamburgare. 
//d. Om summan är större än 25 och mindre än eller lika med 50 och användaren har 
//rabatt skriv – Du kan köpa en stor hamburgare och pommes frites. 
//e. Om summan är större än 60 eller om den är 50 och 60 och användaren har rabatt 
//skriv – Du kan köpa ett meal med dryck.

Console.Write("Hur mycket pengar har du? ");
int customerCashAmount = Convert.ToInt32(Console.ReadLine());
Console.Write("Hur du rabatt? 1: ja, 2: nej. " );
int haveDiscount = Convert.ToInt32(Console.ReadLine());

//Switch
bool discount = (haveDiscount) switch
{
    1 => true,
    2 => false,
    _ => false
};

// vanlig switch
//switch (haveDiscount)
//{
//    case 1:
//        discount = true;
//        break;
//    case 2:
//        discount = false;
//        break;
//    default:
//        discount = false;
//        break;
//}

if (discount == false && customerCashAmount >= 15 && customerCashAmount <= 25)
{
    Console.WriteLine("Du kan köpa en liten hamburgare.");
}
else if (discount == true && customerCashAmount >= 15 && customerCashAmount <= 25)
{
    Console.WriteLine("Du kan köpa en liten hamburgare och en pommes frites. ");
}
else if (discount == false && customerCashAmount >= 25 && customerCashAmount <= 50)
{
    Console.WriteLine("Du kan köpa en stor hamburgare.");
}
else if (discount == true && customerCashAmount >= 25 && customerCashAmount <= 50)
{
    Console.WriteLine("Du kan köpa en stor hamburgare och pommes frites.");
}
else if (discount == false && customerCashAmount >= 60 || discount == false && customerCashAmount > 50)
{
    Console.WriteLine("Du kan köpa ett meal med dryck.");
}

Console.ReadKey();