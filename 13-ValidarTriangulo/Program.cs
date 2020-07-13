using System;

namespace _13_ValidarTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {   
            int A;
            int B;
            int C;

            Console.WriteLine("=========================");
            Console.WriteLine("===== Triangulando ======");
            Console.WriteLine("=========================");

            Console.WriteLine("Digite o Primeiro Número");
            A=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número");
            B=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Terceiro Número");
            C=int.Parse(Console.ReadLine());

            if((A<B+C)&&(B<A+C)&&(C<A+B))
            {
                int[] M= new int[]{A,B,C};

                Array.Sort(M);
                System.Console.WriteLine("A Ordem dos Lados do Menor para o Maior é:");

                foreach (int item in M)
                {
                    Console.WriteLine(item);
                }
            }else
            {
                Console.WriteLine("A combinação informada não forma um Triângulo");
            }


        }
    }
}
