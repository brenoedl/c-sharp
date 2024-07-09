using System;
using System.Threading;
using System.Threading.Channels;
internal class Program{
    private static void Main(string[] args) {
        int d = DateTime.Now.Day;
        int m = DateTime.Now.Month;
        int a = DateTime.Now.Year;
        Console.Write("Hoje é dia ");
        Thread.Sleep(1000);
        Console.Write(d);
        Thread.Sleep(1000);
        Console.Write(" do mês ");
        Thread.Sleep(1000);
        Console.Write(m);
        Thread.Sleep(1000);
        Console.Write(" de ");
        Thread.Sleep(1000);
        Console.WriteLine(a);
        Console.ReadKey();
    }
}
