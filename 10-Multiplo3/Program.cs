using System;

namespace _10_Multiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            
            do
            {
            Console.WriteLine("Digite um número");
            N=int.Parse(Console.ReadLine());

                
            if((N%3)==0)
            {
                Console.WriteLine("O número digitado é multiplo de 3");
            }
            else{
                    Console.WriteLine("O número digitado não é multiplo de #.");
                }
            } while (N!=0);
        }
    }
}
