int sum = 0;
for (int i = 265; i <= 290; i++)
{
    if(i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum / (290 - 265));
Console.ReadKey();