//Skapa en array som skall innehålla temperaturmätningar. Användaren får först upp en fråga
//om hur många mätningar som skall registreras. Sedan får denne ange värde för varje
//mätning. Detta skall vara decimaltal. Skriv sedan ut alla mätningar och avsluta med att ange
//en max och en medeltemperatur.

Console.WriteLine("Hur många mätningar skall registreras? ");
double amountOfMeasurments = Convert.ToDouble(Console.ReadLine());

double[] measurments = new double[(int)amountOfMeasurments];