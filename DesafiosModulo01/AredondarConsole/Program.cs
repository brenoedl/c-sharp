using System;
internal class Program
{
    private static void Main(string[] args)
    {
        float num = 0;
        int arredomdar;
        int parte;
        Console.Write("Digite um numero real: ");
        float.TryParse(Console.ReadLine(), out num);
        parte = (int) num;
        arredomdar = Convert.ToInt16(num);
        Console.WriteLine($"Você digitou o valor {num:n}.");
        Console.WriteLine($"A parte inteira é {parte:d}.");
        Console.WriteLine($"Arredondando, temos o valor {arredomdar:d}.");
        Console.ReadKey();
    }
}