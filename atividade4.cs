using System;

namespace lista2{

    public static class atividade4{

        public static void main(){
            int anoN;
            int idade = 0;


            Console.WriteLine("Digite seu ano de nascimento: ");

            anoN = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Voce já fez aniversário esse ano (s/n): ");

            bool resposta = Console.ReadLine() == "s" ? true : false;

            idade = DateTime.Now.Year - anoN;

            if(resposta){

                Console.WriteLine(idade);

                if(idade >= 18){
                    Console.WriteLine("Parabens voce tem idade suficiente para carteira de motorista");
                }
            }
            else{
                idade = idade - 1;

                Console.WriteLine(idade);

                if(idade >= 18){
                    Console.WriteLine("Parabens voce tem idade suficiente para carteira de motorista");
                }
            }
        }
    }
}
