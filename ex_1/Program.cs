using System;

class Program
{
    static void Main(string[] args)
    {
        char input;
        int totalHomens = 0, totalMulheres = 0, totalCriancas = 0, totalIdosos = 0;
        int totalIndividuos = 0;

        Console.WriteLine("Entre com um caractere (H - Homem, M - Mulher, C - Criança, I - Idoso):");

        do
        {
            input = char.ToUpper(Console.ReadKey().KeyChar);

            switch (input)
            {
                case 'H':
                    totalHomens++;
                    break;
                case 'M':
                    totalMulheres++;
                    break;
                case 'C':
                    totalCriancas++;
                    break;
                case 'I':
                    totalIdosos++;
                    break;
                case 'F':
                    break;
                default:
                    Console.WriteLine("\nEntrada inválida. Entre com um caractere válido (H, M, C, I ou F):");
                    continue;
            }

            totalIndividuos++;

            if (input != 'F')
            {
                Console.WriteLine("\nEntre com um caractere (H - Homem, M - Mulher, C - Criança, I - Idoso):");
            }

        } while (input != 'F');

        double percentualHomens = (double)totalHomens / totalIndividuos * 100;
        double percentualMulheres = (double)totalMulheres / totalIndividuos * 100;
        double percentualCriancas = (double)totalCriancas / totalIndividuos * 100;
        double percentualIdosos = (double)totalIdosos / totalIndividuos * 100;

        Console.WriteLine($"\nTotal de homens = {totalHomens} - {percentualHomens:F}%");
        Console.WriteLine($"Total de mulheres = {totalMulheres} - {percentualMulheres:F}%");
        Console.WriteLine($"Total de crianças = {totalCriancas} - {percentualCriancas:F}%");
        Console.WriteLine($"Total de idosos = {totalIdosos} - {percentualIdosos:F}%");
    }
}
