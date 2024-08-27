//Be användaren ange vilken kategori den tillhör-vuxen, pensionär, student. Om den är
//pensionär eller student kostar resan 20 kr . Om den är vuxen kostar resan 30 kr . Annars skall
//användaren informeras att den har angett en felaktig kategori. 

AgeCategory();

Console.ReadKey();

void AgeCategory()
{

    try
    {
        Console.Write("Är du Pensionär, student eller vuxen?");
        string ageCategory = Console.ReadLine().ToLower();
        if (ageCategory != "pensionär" && ageCategory != "student" && ageCategory != "vuxen")
        {
            AgeCategory();
        }
        else if (ageCategory == "pensionär" || ageCategory == "student")
        {
            Console.WriteLine("Din resa kostar 20kr.");
        }
        else
        {
            Console.WriteLine("Din resa kostar 30kr");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}