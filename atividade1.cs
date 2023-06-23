using System;

namespace lista2{

    public static class atividade1{

        public static void main(){
            int numero1;
            int numero2;
//erro de referencia nula, n sei como resolver
            Console.WriteLine("digite o primeiro numero");

            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");

            numero2 = int.Parse(Console.ReadLine());

            if(numero1>numero2){
                Console.WriteLine("O primeiro numero digitado é o maior");
            }
            else{
                Console.WriteLine("o segundo numero digitado é o maior");
            }
        }
    }
}