internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um número: ");
       num = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Você digitou o número " + num);
        Console.ReadKey();
    }
}
