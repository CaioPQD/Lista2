using System;

namespace lista2
{
    public static class atividade6{
        public static void main()
        {
            int numeroQuartos = 75;
            double descDiaria = 0.25;
            double valorDiaria = 0;
            double valorDdesc = 0;


            Console.WriteLine("Digite o valor da diaria: ");

            var entrada = Console.ReadLine();

            valorDiaria = double.Parse(entrada);
            valorDdesc = valorDiaria * descDiaria;

            Console.WriteLine("Valor promocional: " + (valorDiaria - valorDdesc));
            Console.WriteLine("Valor promocional com 80% de ocupacao: " + (valorDiaria - valorDdesc) * (numeroQuartos * 0.8));
            Console.WriteLine("Valor total com 50% de ocupacao: " + valorDiaria * (numeroQuartos * 0.5));
            Console.WriteLine("Diferença entre os valores promocional e normal: " + ((valorDiaria - valorDdesc) * (numeroQuartos * 0.8) - valorDiaria * (numeroQuartos * 0.5)));
        }
    }
}
