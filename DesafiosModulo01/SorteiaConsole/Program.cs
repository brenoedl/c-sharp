using System;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        int inicio = 0, fim = 0;
        Console.WriteLine("Sorteador de número");
        Console.WriteLine("----------------------");
        Console.Write("Ínicio: ");
        int.TryParse(Console.ReadLine(), out inicio);
        Console.Write("Fim: ");
        int.TryParse(Console.ReadLine(), out fim);
        Random rand = new Random();
        int gerador = rand.Next(inicio, fim + 1);
        Console.WriteLine("----------------------");
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("Sorteando....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, 5);
        Console.WriteLine($"Entre {inicio} e {fim} sortiei o valor {gerador}.");
        Console.ReadKey();
    }
}