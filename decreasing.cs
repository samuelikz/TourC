using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int[] numeros = { 150, 18, 540, 320, 7, 1350, 25, 2777, 3, 87 }; //Array

        static void Main(string[] args)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= 10 && numeros[i] <= 99 || numeros[i] >= 1000)
                {
                    Console.Write("'{0}' ", numeros[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
