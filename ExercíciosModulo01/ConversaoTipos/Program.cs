using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int a1 = 2;
        float b1 = a1;
        Console.WriteLine("O valor de a1 é " + a1 + " do tipo " + a1.GetType());
        Console.WriteLine("O valor de b1 é " + b1 + " do tipo " + b1.GetType());
        float a2 = 2.9999f;
        int b2 = (int) a2;
        Console.WriteLine("O valor de a2 é " + a2 + " do tipo " + a2.GetType());
        Console.WriteLine("O valor de b2 é " + b2 + " do tipo " + b2.GetType());
        float a3 = 2.9999f;
        int b3 = Convert.ToInt16(a3);
        Console.WriteLine("O valor de a3 é " + a3 + " do tipo " + a3.GetType());
        Console.WriteLine("O valor de b3 é " + b3 + " do tipo " + b3.GetType());
        Console.ReadKey();
    }
}
