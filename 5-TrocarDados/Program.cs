using System;

namespace TrocarDados
{
    class Program
    {
        static void Main(string[] args)
        {
            float A;
            float B;
            float C;

            Console.WriteLine("==================");
            Console.WriteLine("Trocando as Bolas");
            Console.WriteLine("==================");


            Console.WriteLine("Digite um valor para A");
            A=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B");
            B=float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Você digitou {A} para A e {B} para B");
            System.Console.WriteLine();

            C=B;
            B=A;
            A=C;
            Console.WriteLine($"O novo valor de A é:{A}\n e o novo de B é: {B}");






        }
    }
}
