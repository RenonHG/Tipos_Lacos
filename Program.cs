using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_lacos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("1- Do While \n2- For \n3- Switch Case \n4- Array \nEscolha um opção: ");
            int menu = int.Parse(Console.ReadLine());
            Console.Clear();

            //Primeiro exemplo: DO WHILE
            if (menu == 1)
            {
                //DO
                //{
                //trecho do código
                //} while (true)
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                int contador = 4;
                while (contador <=3)
                {
                    Console.WriteLine("While: " + contador);
                    contador++;
                }
                // Ele executa pelo menos uma vez o código, mesmo estando errado como no código acima.
                do
                {
                    Console.WriteLine("Do While: " + contador);
                    contador++;

                } while (contador <= 3);
                // do {código } while (condição)
            }
           
            else if (menu == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //for (definição do contador; condição; incremento) {código}

                for (int cont = 0; cont <3; cont++)
                {
                    Console.WriteLine("for: " + cont);
                }

            }

            //Exemplo 3: Utilizando o Switch
            else if(menu == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Digite um valor: ");
                int condicao = int.Parse(Console.ReadLine());


                switch (condicao)
                {
                    case 0:
                        Console.WriteLine("Estou na condição: " + condicao);
                        break;

                    case 1:
                        Console.WriteLine("Estou na condição: " + condicao);
                        break;

                    case 2:
                        Console.WriteLine("Estou na condição: " + condicao);
                        break;

                    case 3:
                        Console.WriteLine("Estou na condição: " + condicao);
                        break;

                    case 5:
                        Console.WriteLine("Estou na condição: " + condicao);
                        break;

                    default:
                        Console.WriteLine("Você escolheu uma opção inválida!");
                        break;


                }

            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Press <enter> to continue...");
            Console.ReadKey();
        }
    }
}
