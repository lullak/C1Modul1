//Skapa en array som skall innehålla temperaturmätningar. Användaren får först upp en fråga
//om hur många mätningar som skall registreras. Sedan får denne ange värde för varje
//mätning. Detta skall vara decimaltal. Skriv sedan ut alla mätningar och avsluta med att ange
//en max och en medeltemperatur.

Console.WriteLine("Hur många mätningar skall registreras? ");
int amountOfMeasurments = Convert.ToInt32(Console.ReadLine());

double[] measurments = new double[amountOfMeasurments];

for (int i = 0; i < measurments.Length; i++)
{
    Console.Write("Ange temp: ");
    measurments[i] = Convert.ToDouble(Console.ReadLine());
}

foreach (var measurment in measurments)
{
    Console.WriteLine(measurment);
}

Console.WriteLine($"Max tempen är {measurments.Max()} och medel är {measurments.Average()}");
Console.ReadKey();