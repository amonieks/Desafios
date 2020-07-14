using System;

namespace _12_OrdenarNUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Ordenando Números");
            Console.WriteLine("===================");
            System.Console.WriteLine();
            

            
                
                System.Console.WriteLine("Digite o Primeiro Número");
                int A=int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o Primeiro Número");
                int B=int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o Primeiro Número");
                int C=int.Parse(Console.ReadLine());

                int[] N= new int[]{A,B,C};
                Console.Clear();

                Array.Sort(N);
                foreach (int item in N)
                {
                    Console.WriteLine(item);
                }

            
                
              
                          

            



            
        }
    }
}
