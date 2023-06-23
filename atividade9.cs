using System;

namespace lista2
{
    public static class atividade9{
        public static void main()
        {
            Console.WriteLine("Digite um simbolo: ");
            char simbolo = char.Parse(Console.ReadLine());

            switch (simbolo)
            {
                case '<':
                    Console.WriteLine("SINAL DE MENOR");
                    break;
                case '>':
                    Console.WriteLine("SINAL DE MAIOR");
                    break;
                case '=':
                    Console.WriteLine("SINAL DE IGUAL");
                    break;
                default:
                    Console.WriteLine("OUTRO SINAL");
                    break;
            }

            Console.ReadLine();
        }
    }
}