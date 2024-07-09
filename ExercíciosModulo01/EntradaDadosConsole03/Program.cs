using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out num);
        Console.Write("Você digitou o número " + num);
        Console.ReadKey();
    }
}