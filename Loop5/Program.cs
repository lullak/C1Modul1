Console.Write("Mata in ett tal: ");
int tal = Convert.ToInt32(Console.ReadLine());

int siffra = 1;

do
{
    Console.WriteLine(siffra);
    siffra++;
}
while (siffra < tal);


Console.ReadKey();