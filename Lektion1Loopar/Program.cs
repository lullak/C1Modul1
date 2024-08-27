
//for(int i = 0; i <= inmatadTal; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Mata in ett tal, alla tal mellan noll och talet skrivs ut.");
//int givenNumber = Convert.ToInt32(Console.ReadLine());
//int whileCount = 0;
//while(whileCount <= givenNumber)
//{
//    Console.WriteLine(whileCount);
//    whileCount++;
//}
Console.WriteLine("Vad vill du ställa timern på?");
int inmatadTal = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for (int i = inmatadTal; i >= 0; i--)
{   
    Console.ForegroundColor = ConsoleColor.Red;
    
    Console.WriteLine(i);
    Thread.Sleep(1000);
    Console.Clear();
    if (i == 0) { Console.WriteLine("Boom hueshues"); }
}    



Console.ReadLine();


