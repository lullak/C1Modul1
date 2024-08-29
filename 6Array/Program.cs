//Utöka uppgift 5 med att även ange mätdatum för varje mätvärde. Skriv sedan ut varje
//mätvärde på samma sätt men tillsammans med mätdatum. 

Console.WriteLine("Hur många mätningar skall registreras? ");
int amountOfMeasurments = Convert.ToInt32(Console.ReadLine());

double[,] measurments = new double[amountOfMeasurments,2];

for (int i = 0; i < amountOfMeasurments; i++)
{

    {
        Console.Write("Ange temp: ");
        measurments[i, 0] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ange datum: ");
        measurments[i, 1] = Convert.ToDouble(Console.ReadLine());
    }
}

double sum = 0;
for (int i = 0; i < amountOfMeasurments; i++)
{

    {
        sum = measurments[i, 0];
        Console.WriteLine($"Temperaturen är: {measurments[i, 0]}, dagens datum: {measurments[i, 1]}. ");
    }
}

Console.WriteLine($"Medeltemeraturen är {sum/(amountOfMeasurments-1)}");


//Console.WriteLine($"Max tempen är {measurments.Max()} och medel är {measurments.Average()}");
Console.ReadKey();
