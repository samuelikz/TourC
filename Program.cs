using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static string[] menu = {
            "*** Seletor de Opções ***" , "1 - Criar array" , "2 - Incluir elemento", "3 - Consultar elemento",
            "4 - Alterar elemento", "5 - Excluir elemento", "6 - Listar array", "7 - Classificar", "8 - Iniciar array" ,"0 - Fim"
        }; // Array de menu

        static string[] Array = null;
        static int posicao = 0;
        static int tamanho = 0;

        static int opcaoEntrada = 0; // Guardar opção de entrada
        
        static bool arrayCriado= false; // array criado ? false 

        static void Main(string[] args)
        {
            iniciar();
        }// Main Principal

        static void iniciar()
        {
            do
            {
                mostrarMenu(); // Metodo mostrar menu

                try
                {
                    Console.WriteLine();
                    Console.Write("Digite a opção: ");
                    opcaoEntrada = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error) // Tratar qualquer erro
                {
                    Console.WriteLine(error.GetType().FullName);
                    Console.WriteLine(error.Message);
                    continue;
                }

                oprSelecao(); // Metodo opções

            } while (opcaoEntrada != 0); // Finalizar ?

            Console.WriteLine("Finalizar Programa");
        }// Inicio do programa
        static void mostrarMenu() // mostrar array do menu
        {
            foreach (string select in menu)
            {
                Console.WriteLine(select);
            }
        }

        static void oprSelecao() // Entradas
        {
            switch (opcaoEntrada)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("1");
                    criarArray();
                    break;
                case 2:
                    Console.WriteLine("2");
                    incluirElemento();
                    break;
                case 3:
                    Console.WriteLine("3");
                    consultarElemento();
                    break;
                case 4:
                    Console.WriteLine("4");
                    alterarElemento();
                    break;
                case 5:
                    Console.WriteLine("5");
                    excluirElemento();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("----------------------");
                    Console.WriteLine("--> Lista de Array <--");
                    Console.WriteLine("----------------------");
                    Console.WriteLine();
                    listarArray();
                    break;
                case 7:
                    Console.WriteLine("7");
                    classificar();
                    break;
                case 8:
                    Console.WriteLine("8");
                    iniciarArray();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("---> Opção Incorreta  <---");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();

                    break;
            }
        }

        static void arrayIndisponivel()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("-> Array não foi criado <-");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            return;
        }// função informar!

        static void funcaoIndisponivel()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Funcionalidade em Produção <-");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            return;
        }// função informar!

        static void criarArray()
        {
            if (arrayCriado)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("-> Array já foi criado <-");
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                return;
            }
            else
            {
                Console.WriteLine("Informe a quantidade de itens para o array: ");
                tamanho = Convert.ToInt32(Console.ReadLine());

                arrayCriado = true;

                Array = new string[tamanho];

                // Controlar = +1; não funcionando 

                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("->    Array criado     <-");
                Console.WriteLine("-------------------------");
                Console.WriteLine();

            }

        }

        static void incluirElemento() // Não verifica se já existe , bug: pode fazer alteração!
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();
                return;
            }

            //if (ar ==)
            //{

            //}
            
                Console.WriteLine("Informe a posição do elemento a ser incluido: ");
                posicao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome do elemento: ");
                string ar = Convert.ToString(Console.ReadLine());

                Array[posicao - 1] = ar;

                listarArray();
        }

        static void consultarElemento() // Funcionalidade em produção
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;
            }

            funcaoIndisponivel();
        }
        static void alterarElemento() // Não verifica de existe
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;
            }

            Console.WriteLine("Informe a posição do elemento a ser Alterado: ");
            posicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o novo nome do elemento: ");
            string ar = Convert.ToString(Console.ReadLine());

            Array[posicao - 1] = ar;

            listarArray();
        }
        static void excluirElemento()
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;
            }
            Console.WriteLine("Informe a posição do elemento a ser Excluido: ");
            posicao = Convert.ToInt32(Console.ReadLine());

            string ar = null;

            Array[posicao - 1] = ar;

            listarArray();
        }
        static void classificar()// Funcionalidade em produção
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;
            }
            funcaoIndisponivel();
        }

        static void iniciarArray() // Funcionalidade em produção
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;

                // Array = null; não funciona ??
            }
            funcaoIndisponivel();
        }

        static void listarArray() // Não exibindo posição do elemento com o foreach
        {
            if (arrayCriado == false)
            {
                arrayIndisponivel();

                return;
            }
            else
            {
                foreach (var item in Array)
                {
                    Console.WriteLine("Elemento = {0} ", item);
                    Console.WriteLine();
                }

            }

            iniciar();
        
        }

    }
}