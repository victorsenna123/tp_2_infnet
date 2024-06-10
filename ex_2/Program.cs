using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com intervalo inferior:");
        int inferior = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com intervalo superior:");
        int superior = int.Parse(Console.ReadLine());

        int somaPares = 0;
        int somaImpares = 0;

        for (int i = inferior; i <= superior; i++)
        {
            if (i % 2 == 0)
            {
                somaPares += i;
            }
            else
            {
                somaImpares += i;
            }
        }

        Console.WriteLine($"Soma de pares = {somaPares}");
        Console.WriteLine($"Soma dos ímpares = {somaImpares}");
    }
}
