using System;

namespace ConversorFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int C=0;
            int F=0;

            Console.WriteLine("=====================================");
            Console.WriteLine("CONVERSOR FAHRENHEIT");
            Console.WriteLine("=====================================");

            Console.WriteLine("Digite a temperatura em graus Célcius");
            C=int.Parse(Console.ReadLine());

            F=(9*C + 160)/5;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: {F}");
        }
    }
}
