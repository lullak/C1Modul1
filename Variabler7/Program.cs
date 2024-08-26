CalculateAge();

Console.ReadLine();
void CalculateAge()
{
    Console.Write("Vilket år är du född? ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Din ålder är {DateTime.Now.Year - age}");
}