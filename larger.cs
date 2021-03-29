using System;

namespace Atividade_1_3
{
    class Program
    {
        static int[] numeros = { 150, 18, 540, 320, 7, 1350, 25, 2777, 3, 87 }; //Array

        static void Main(string[] args)
        {

            for (int i = 0; i < numeros.Length; ++i) //Mostrar Array
            {
                if (numeros[i] < 500) // True
                {
                    Console.Write("{0} ", numeros[i]);
                }
            }
        }
    }
}
