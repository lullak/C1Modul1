//Skapa en Console application . Be användaren mata in ett datum. Skriv ut ett nytt datum som 
//är exakt 1 år och 4 månder senare än det datum som användaren angivit. Formatera 
//datumet så att inte klockslag visas, bara datumet. 

Console.Write("Mata in ett datum: ");
DateTime dateTime;
if(DateTime.TryParse(Console.ReadLine(), out dateTime))
{
    Console.WriteLine($"Angiven datum: {dateTime:yyyy MM dd}");
    dateTime = dateTime.AddYears(1);
    dateTime = dateTime.AddMonths(4);
    Console.WriteLine($"1 år och 4 månader tillagda till angiven datum: {dateTime:yyyy MM dd}");
}
else
{
    Console.WriteLine("Du har angett datum i fel format");
}

Console.ReadKey();