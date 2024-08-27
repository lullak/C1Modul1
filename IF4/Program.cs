//Be användaren mata in sin ålder. Om den är mindre än 18 är användaren ej myndig. Om den
//är över 65 är den pensionär. Annars är den myndig men inte pensionär. Meddela användaren
//om vad som gäller för dennes ålder. Kontrollera också att användaren har matat in ett riktigt
//tal. Har den matat in andra tecken än siffror meddela användaren att den har ar matat in en
//felaktig ålder. 


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