using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static int[] numeros = { 150, 18, 540, 320, 7, 1350, 25, 2777, 3, 87 }; //Array

        static void Main(string[] args)
        {

            for (int i = 0; i < numeros.Length; ++i) //Mostrar Array
            {
                if (numeros[i] % 2 == 0) // True
                {   
                    Console.Write("{0} ", numeros[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
