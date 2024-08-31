//Sortera strängen "231596874" till strängen "123456789" med en egen sortfunktion

// Sort via Array.Sort
//string numbers = "231596874";
//char[] numbersArray = numbers.ToCharArray();

//Array.Sort(numbersArray);
//string sortedArray = new string(numbersArray);
//Console.WriteLine(sortedArray);

//Metod
string input = "334626453625432";

StringSortNumbers(input);

void StringSortNumbers(string stringNumbersToSort)
{

    string numbers = stringNumbersToSort;
    char[] chars = numbers.ToCharArray();

    Array.Sort(chars);
//  string sortedArrayToString = new string(chars);    // konvertera till string
    Console.WriteLine(chars);

}

Console.ReadLine();