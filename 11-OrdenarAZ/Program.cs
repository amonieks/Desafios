using System;

namespace _11_OrdenarAZ
{
    class Program
    {
        static void Main(string[] args)
        {
             
            

            Console.WriteLine("Digite o Primeiro nome");
                string A=Console.ReadLine();
            Console.WriteLine("Digite o Segundo nome");
                string B=Console.ReadLine();

           string[] L = new string[]{A,B};
           
                Console.Clear();

                Array.Sort(L);

                foreach (string item in L)
                {
                    Console.WriteLine(item);
                }
       
        }
    }
}
