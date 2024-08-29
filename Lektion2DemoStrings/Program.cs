//string valueString = "aefwEFWFwefLPMGea";
//valueString = valueString.Replace("a", "A");

//Console.WriteLine(valueString);

//string names = "Lisa,Kalle,Anna,Stina";

//string[] namesArray = names.Split(',');

//namesArray = namesArray;

//Array.IndexOf(namesArray, valueString);

//string fullName = "lisa Lind";
//int position = fullName.IndexOf("");
//string firstName = fullName.Substring(0, position);
//firstName = fullName.Substring(0, 1).ToUpper();
//Console.WriteLine(firstName);
//string lastName = fullName.Substring(position + 1);

//Vi skall bygga en sökfunktion som går mot en array med namn
//Det skall gå att skriva in ett sökvillkor och få fram de namn som matchar villkoret

string[] nameList = new string[] { "Kalle Karlsson", "Lisa Lind", "Kalle Lind", "Anna Lindberg" };

Console.Write("Ange ett sökvillkor: ");
string searchCondition = Console.ReadLine().ToLower();

if (searchCondition == "" || searchCondition == " ")
{
    Console.WriteLine("Du måste ange ett sökvillkor");
}
else
{
    foreach (string name in nameList)
    {
        if (name.ToLower().Contains(searchCondition))
        {
            Console.WriteLine(name);
        }
    }
}









Console.ReadKey();