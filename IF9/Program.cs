//Be användaren mata in ett bilmärke. Om det inte är lika med Volvo skall du kontrollera om 
//det är en Volkswagen, BMW eller Audi. Skriv ut att bilen är tysk. Om den är Renault eller
//Peugeot eller Citroen skriv att den är fransk. Annars skriv ut att bilen inte är tysk eller fransk 
//eller svensk. Skriv inget om bilen är en Volvo. 

Console.Write("Mata in ett bilmärke:");
string userCarBrand = Console.ReadLine().ToLower();


if (userCarBrand != "volvo")
{
    if (userCarBrand == "volkswagen" || userCarBrand == "bmw" || userCarBrand == "audi")
    {
        Console.WriteLine("Bilen är tysk.");
    }
    else if (userCarBrand == "renault" || userCarBrand == "peugeot" || userCarBrand == "citroen")
    {
        Console.WriteLine("Bilen är fransk.");
    }
    else
    {
        Console.WriteLine("Bilen är inte tysk, svensk eller fransk.");
    }
}

Console.ReadKey();