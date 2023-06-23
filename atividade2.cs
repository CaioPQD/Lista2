using System;

namespace lista2{

    public static class atividade2{

        public static void main(){
            int numero1;
            int numero2;
            int soma = 0;

            Console.WriteLine("digite o primeiro numero");
//erro de referencia nula...
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");

            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            if(soma >= 10){
                Console.WriteLine(soma + 5);
            }
            else{
                Console.WriteLine(soma + 7);
            }
        }
    }
}