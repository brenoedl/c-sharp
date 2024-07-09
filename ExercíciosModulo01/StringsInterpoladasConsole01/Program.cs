using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        Console.Write("Qual é o seu nome? ");
        nome = Console.ReadLine();
        Console.WriteLine($"Muito prazer em te conhecer, {nome}!");
    }
}