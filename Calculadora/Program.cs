using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            string opcao = "";



            while (opcao != "nao")
            {

                Console.WriteLine("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual operação você quer fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Nenhuma das opções acima, DESEJO SAIR" + "\n");
                Console.WriteLine("Digite sua opção: ");
                switch (Console.ReadLine())
                {

                    case "1":

                        Console.WriteLine("O resultado é: " + (valor1 + valor2));
                        break;

                    case "2":

                        Console.WriteLine("O resultado é: " + (valor1 - valor2));
                        break;

                    case "3":
                        if (valor1 >= valor2)
                        {
                            Console.WriteLine("O resultado é: " + (valor1 / valor2));
                        }
                        else
                        {
                            Console.WriteLine("DIVISÃO INVALIDA!!!");
                        }
                        break;


                    case "4":


                        Console.WriteLine("O resultado é: " + (valor1 * valor2));
                        break;

                }
                Console.WriteLine("Deseja continuar?: ");

                opcao = Console.ReadLine();

                

            }
        }
    }
}