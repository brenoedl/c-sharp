using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string produto1, produto2;
        float preço1 = 0, preço2 = 0;
        Console.Write("Produto 1: ");
        produto1 = Console.ReadLine();
        Console.Write("Preço 1: $R");
        float.TryParse(Console.ReadLine(), out preço1);
        Console.Write("Produto 2: ");
        produto2 = Console.ReadLine();
        Console.Write("Preço 2: $R");
        float.TryParse(Console.ReadLine(), out preço2);
        Console.SetCursorPosition(0, 10);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{"Produto", -20}{"Preço", 13}");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"{produto1, -20}{preço1, 13:c2}");
        Console.WriteLine($"{produto2, -20}{preço2, 13:c2}");
        Console.ResetColor();
        Console.ReadKey();
    }
}