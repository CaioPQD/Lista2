using System;

namespace lista2{

    public static class atividade3{

        public static void main(){
            int a;
            int b;

            Console.WriteLine("digite o valor de a:");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de b:");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = " + -b/a );
        }
    }
}