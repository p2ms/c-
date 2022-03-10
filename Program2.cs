using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int valor = 0; 


            while(valor != 2)
            {
                if (numero == 0)
                {
                    numero = numero + 1;
                }
                else
                {
                    Console.WriteLine("Errou!");
                }
                Console.WriteLine("jogo de adivinhação");
                Console.WriteLine("digite um numero");
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("acertou");
            Console.ReadKey();

        }
    }
}
