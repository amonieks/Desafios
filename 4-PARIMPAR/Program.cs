using System;

namespace PARIMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero=0;
            
            Console.WriteLine("=====================");
            Console.WriteLine("Programa PARIMPAR");
            Console.WriteLine("=====================");


            Console.WriteLine("Digite um número");
            Numero=int.Parse(Console.ReadLine());

            if((Numero%2)==0)
            {

                Console.WriteLine("O Número inserido é Par");

            }else{

                Console.WriteLine("O Número inserido é Impar");

                }


        }
    }
}
