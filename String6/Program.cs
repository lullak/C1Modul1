﻿//Du har en kommaseparerad sträng som ser ut så här ”ett, två, tre, fyra, fem, sex, sju”. Skapa en 
//array där varje värde i strängen hamnar i en egen position i arrayen dvs ett hamnar i första 
//positionen och två i andra positionen och tre i den tredje osv. 

string stringToArray = "ett,två,tre,fyra,fem,sex,sju";

string[] newStringArray = stringToArray.Split(',');

foreach (string str in newStringArray)
{
    Console.WriteLine(str);
}




Console.ReadKey();
