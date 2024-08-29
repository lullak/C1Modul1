Random random = new Random();
int randomNumber = random.Next(1,21
    );
int guessedNumber;


while(true){
    Console.WriteLine("Gissa tal, mellan 1 och 20: ");
    guessedNumber = Convert.ToInt32(Console.ReadLine());

    if (guessedNumber < randomNumber)
    {
        Console.WriteLine("Du gissade för lågt");
    }
    else if (guessedNumber > randomNumber)
    {
        Console.WriteLine("Du gissade för högt");
    }
    else {
        Console.WriteLine("Du gissade rätt!");
        break;
    }
}

Console.WriteLine(randomNumber);
Console.ReadKey();