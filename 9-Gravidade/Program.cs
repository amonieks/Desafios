using System;

namespace _9_Gravidade
{
    class Program
    {
        static void Main(string[] args)
        {

            string O;
            string Planeta="";
            double Peso;
            
            //|   | Gravidade Relativa | Planeta  |
            //|---|--------------------|----------|
            //| 1 | 0,37               | Mercúrio |
            //| 2 | 0,88               | Vênus    |
            //| 3 | 0,38               | Marte    |
            //| 4 | 2,64               | Júpiter  |
            //| 5 | 1,15               | Saturno  |
            //| 6 | 1,17               | Urano    |

            Console.WriteLine("========================");
            Console.WriteLine("Balança de outro Planeta");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("Digite seu peso na terra");
            Peso=double.Parse(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine();
            Console.WriteLine("Escolha um planeta da lista abaixo:");
            System.Console.WriteLine();
            Console.WriteLine("| Opção  | Planeta  |");
            Console.WriteLine("|--------|----------|");
            Console.WriteLine("| 1      | Mercúrio |");
            Console.WriteLine("| 2      | Vênus    |");
            Console.WriteLine("| 3      | Marte    |");
            Console.WriteLine("| 4      | Júpiter  |");
            Console.WriteLine("| 5      | Saturno  |");
            Console.WriteLine("| 6      | Urano    |");
            O=Console.ReadLine();
            Console.Clear();
            switch (O)
            {
                case "1": Peso=Peso*0.37;
                            Planeta="Mercúrio";
                    break;
                case "2": Peso=Peso*0.88;
                            Planeta="Vênus";
                    break;
                case "3": Peso=Peso*0.38;
                            Planeta="Marte";
                    break;
                case "4": Peso=Peso*2.64;
                            Planeta="Júpter";
                    break;
                case "5": Peso=Peso*1.15;
                            Planeta="Saturno";
                    break;
                case "6": Peso=Peso*1.17;
                            Planeta="Urano";
                    break;

                
                default: System.Console.WriteLine("Escolha uma Opção válida");
                    break;
            }
            
            Console.WriteLine($"Seu peso no Planeta {Planeta} é de {Peso}kg");


            


            
        }
    }
}
