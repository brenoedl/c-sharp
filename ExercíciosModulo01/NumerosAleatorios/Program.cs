using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int num1 = rnd.Next();
        int num2 = rnd.Next(10);
        int num3 = rnd.Next(1, 20);
        Console.WriteLine("Primeiro número sorteado foi: " + num1);
        Console.WriteLine("Segundo número sorteado foi: " + num2);
        Console.WriteLine("Terceiro número sorteado foi: " + num3);
        Console.ReadKey();
    }
}