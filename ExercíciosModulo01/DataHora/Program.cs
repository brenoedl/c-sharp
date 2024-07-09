using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int dia = DateTime.Now.Day;
        int mes = DateTime.Now.Month;
        int ano = DateTime.Now.Year;
        int hora = DateTime.Now.Hour;
        int minuto = DateTime.Now.Minute;
        int segundo = DateTime.Now.Second;
        Console.WriteLine(dia + "/" + mes + "/" + ano + " " + hora + ":" + minuto + ":" + segundo);
        Console.ReadKey();
    }
}
