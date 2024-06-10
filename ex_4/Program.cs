using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro N para mostrar os N primeiros números da sequência de Fibonacci:");
        int n = int.Parse(Console.ReadLine());

        MostrarFibonacci(n);
    }

    static void MostrarFibonacci(int n)
    {
        int primeiroNumero = 0;
        int segundoNumero = 1;

        Console.WriteLine($"Os {n} primeiros números da sequência de Fibonacci são:");
        Console.Write($"{primeiroNumero}, {segundoNumero}");

        for (int i = 2; i < n; i++)
        {
            int proximoNumero = primeiroNumero + segundoNumero;
            Console.Write($", {proximoNumero}");
            primeiroNumero = segundoNumero;
            segundoNumero = proximoNumero;
        }

        Console.WriteLine();
    }
}
