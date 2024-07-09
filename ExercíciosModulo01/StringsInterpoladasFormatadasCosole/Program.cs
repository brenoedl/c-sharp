using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string nome = "Breno";
        byte idade = 22;
        float peso = 55.369f;
        Console.WriteLine($"Olá, {nome, -10} você tem {idade, 10:d3} anos de idade e pesa {peso:n}Kg.");
        Console.ReadKey();
    }
}