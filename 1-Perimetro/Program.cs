using System;


namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base=0;
            double Altura=0;
            double Area=0;
            double Perimetro=0;
            double Diagonal=0;
            
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Cálculo de Um Retanguloa");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("======");
            }
            Console.WriteLine("-----------------------------------");
            


            Console.WriteLine("Insira o valor da base do retângulo");
            Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da altura do retângulo");
            Altura = double.Parse(Console.ReadLine());

            Area = Base*Altura;
            Perimetro=(Base+Altura)*2;
            Diagonal=System.Math.Sqrt((Base*Base)+(Altura*Altura));

            Console.WriteLine($"O valor da Area é:{Area}");
            Console.WriteLine($"O valor do Perimetro é:{Perimetro}");
            Console.WriteLine($"O valor da Diagonal é:{Diagonal}");
        }
    }
}
