using System;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetCursorPosition(10, 4);
        Thread.Sleep(1000);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" MEU ");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.BackgroundColor= ConsoleColor.Yellow;
        Console.ForegroundColor= ConsoleColor.Green;
        Console.Write(" BRASIL ");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" BRASILERO ");
        Console.ResetColor();
        Console.ReadKey();
    }
}