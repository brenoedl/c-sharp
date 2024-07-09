using System;
internal class Program
{
    private static void Main(string[] args)
    {
        float sal = 0;
        Console.Write("Qual o seu salário? ");
        float.TryParse(Console.ReadLine(), out sal);
        Console.WriteLine($"Você ganha {sal:c} por mês.");
        Console.ReadKey();
    }
}