using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int nasc = 0;
        int atual = DateTime.Now.Year;
        int idade;
        Console.Write("Em que ano você nasceu? ");
        int.TryParse(Console.ReadLine(), out nasc);
        idade = atual - nasc;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine($"Atualmente estamos em {atual:d}.");
        Console.WriteLine($"Se você nasceu {nasc:d}, vai ter {idade:d} anos.");
        Console.ReadKey();
    }
}