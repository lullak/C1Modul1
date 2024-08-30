//Utöka uppgift 5 med att även ange mätdatum för varje mätvärde. Skriv sedan ut varje
//mätvärde på samma sätt men tillsammans med mätdatum. 

Console.WriteLine("Hur många mätningar skall registreras? ");
int amountOfMeasurments = Convert.ToInt32(Console.ReadLine());

double[,] measurments = new double[amountOfMeasurments,2];
int count = 0;
double maxValue = 0;
double sumTemp = 0;
double averageTemp = 0;

while (count < amountOfMeasurments)
{
    Console.Write("Ange temp: ");
    measurments[count, 0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ange datum: ");
    measurments[count, 1] = Convert.ToDouble(Console.ReadLine());

    if (maxValue < measurments[count,0])
    {
        maxValue = measurments[count,0];
    }


    sumTemp = measurments[count, 0] + sumTemp;
    count++;
}

averageTemp = sumTemp / count;

for (int i = 0; i < amountOfMeasurments; i++)
{

    {
        Console.WriteLine($"Temperaturen är: {measurments[i, 0]}, dagens datum: {measurments[i, 1]}. ");
    }
}




Console.WriteLine($"Max tempen är {maxValue:f2} och medeltempen är {averageTemp:f1}");
Console.ReadKey();
