internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        Console.Write("Qual o seu nome? ");
        nome = Console.ReadLine();
        Console.Write("Muito prazer em te conhecer, " + nome + "!");
        Console.ReadKey();
    }
}
