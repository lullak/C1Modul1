AgeControl();

Console.ReadKey();

void AgeControl()
{
    
    try
    {
        int age = 0;
        Console.Write("Mata in din ålder: ");
        age = Convert.ToInt32(Console.ReadLine());
        if (age <= 0 || age > 115)
        {
            AgeControl();
        }
        else if (age > 0 && age < 18)
        {
            Console.WriteLine("Du är inte myndig");
        }
        else if (age > 65)
        {
            Console.WriteLine("Du är myndig och pensionär");
        }
        else
        {

            Console.WriteLine("Du är myndig men inte pensionär");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Måste vara siffror mellan 0-115");
        AgeControl();
    }
}