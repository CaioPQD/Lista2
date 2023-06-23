using System;

namespace lista2
{
    public static class atividade10{
        public static void main(){
            Console.WriteLine("Digite a velocidade max permitida: ");
            int velocidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade do motorista: ");
            int velocidadeMotorista = int.Parse(Console.ReadLine());

            if (velocidadeMotorista <= velocidadeMaxima)
            {
                Console.WriteLine("Motorista respeitou a lei");
            }
            else
            {
                int diferencaVelocidade = velocidadeMotorista - velocidadeMaxima;
                int valorMulta = 0;

                if (diferencaVelocidade <= 10)
                {
                    valorMulta = 50;
                }
                else if (diferencaVelocidade <= 30)
                {
                    valorMulta = 100;
                }
                else
                {
                    valorMulta = 200;
                }

                Console.WriteLine($"O valor da multa é de R${valorMulta}");
            }

            Console.ReadLine();
        }
    }
}