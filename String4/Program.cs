//Du har strängen string namn="kurt andersson";
//Skriv kod så att förnamn och efternamn i variabeln namn börjar med stora bokstäver. 
//Resultatet skall bli så här "Kurt Andersson" 

//string name = "kurt andersson";
//name = name.Replace("kurt", "Kurt");
//name = name.Replace("andersson", "Andersson");

//Console.WriteLine(name);
string name = "kurt andersson";
int position = name.IndexOf(" ");
string lastName = "A" + name.Substring(position + 2, name.Length - (position + 2));
string firstName = "K" + name.Substring(1, position - 1);



Console.WriteLine(name.Length);
Console.WriteLine($"{firstName} {lastName}");



Console.ReadKey();