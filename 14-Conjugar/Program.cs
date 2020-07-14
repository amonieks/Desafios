using System;

namespace _14_Conjugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("==== Conjugando ====");
            Console.WriteLine("====================");

            
            
            Console.WriteLine("Digite um verbo");
            string V = Console.ReadLine();
            

            if (V.Contains("ar"))
            {
                string M = V.Split("ar")[0];

                Console.WriteLine($"Radical: {M}");
                Console.WriteLine($"1 Pessoa: {M}o");
                Console.WriteLine($"2 Pessoa: {M}a");
                Console.WriteLine($"3 Pessoa: {M}a");


            }else if(V.Contains("ir"))
            {
                string M= V.Split("ir")[0];
                
                Console.WriteLine($"Radical: {M}");
                Console.WriteLine($"1 Pessoa: {M}o");
                Console.WriteLine($"2 Pessoa: {M}e");
                Console.WriteLine($"3 Pessoa: {M}e");



            }else if(V.Contains("er"))
            {
                string M= V.Split("er")[0];
                
                Console.WriteLine($"Radical: {M}");
                Console.WriteLine($"1 Pessoa: {M}o");
                Console.WriteLine($"2 Pessoa: {M}e");
                Console.WriteLine($"3 Pessoa: {M}e");
                
            }
            

           
            
            
            
            

        }
    }
}
