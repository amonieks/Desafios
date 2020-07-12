using System;

namespace _8_ImgTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Desenhando um triângulo");
            Console.WriteLine("=====================");

            Console.WriteLine("Digite a altura do Triângulo");
            int Valor=int.Parse(Console.ReadLine());
            int linha=Valor;

            for (int i = 0; i < Valor; i++)
            {                

                for (int j = 0; j < linha; j++)
                {
                    Console.Write("*");
                                            
                }
                linha=linha-1;  
                
                Console.WriteLine("");
            }
            
        }
    }
}
