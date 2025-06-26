using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motores
{
    internal class Motores
    {
        static void Main(string[] args)
        {
            double motormaiorvalor = 0;
            double motormenorvalor = 0;
            double[] motores = new double[10];
            int z = 0;
            int i = 0;
            double valorinserido = 0;
            int opcao;
            bool verifica;

            double maiorvalor = double.MinValue;
            double menorvalor = double.MaxValue;
            do
            {
                Console.Clear();
                Console.WriteLine("┌──────────────────────┐");
                Console.WriteLine("│MENU                  │");
                Console.WriteLine("│SAIR              (0) │");
                Console.WriteLine("│LANÇAR NOVO MOTOR (1) │");
                Console.WriteLine("│VER TABELA        (2) │");
                Console.WriteLine("│VER O MAIOR       (3) │");
                Console.WriteLine("│VER O MENOR       (4) │");
                Console.WriteLine("└──────────────────────┘");

                Console.Write("Selecione uma das opções: ");
                verifica = int.TryParse(Console.ReadLine(), out opcao);
                while ((opcao < 0 || opcao > 4) || verifica == false)
                {
                    Console.Write("Selecione uma das opções (insira um valor entre 1 e 4): ");
                    verifica = int.TryParse(Console.ReadLine(), out opcao);                  
                }

                switch (opcao)
                {

                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Qual motor? (1 A 10) ");
                            verifica = int.TryParse(Console.ReadLine(), out i);                           
                            while ((i < 1 || i > 10) || verifica == false)
                            {
                                Console.Write("Insira um valor entre 1 e 10: ");
                                i = int.Parse(Console.ReadLine());
                            }

                            do
                            {
                                Console.Write("Valor do motor: ");
                                valorinserido = double.Parse(Console.ReadLine());
                            }
                            while (valorinserido < 0 || verifica == false);
  
                        }
                        motores[i - 1] += valorinserido;

                        
                        if (valorinserido > maiorvalor) 
                        { 
                            maiorvalor = valorinserido; motormaiorvalor = i - 1; 
                        }
                        if (valorinserido < menorvalor) 
                        { 
                            menorvalor = valorinserido; motormenorvalor = i - 1; 
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Tabela dos valores:");
                        for (z = 0; z < motores.Length; z++)
                        { Console.WriteLine("Motor {0} | Valor: {1}", z + 1, motores[z]); }
                        Console.ReadKey();


                        break;

                    case 3:
                        if (menorvalor == double.MaxValue)
                        {
                            Console.WriteLine("Nenhum valor foi digitado.");
                        }
                        else
                        {
                            Console.WriteLine("Motor {0} , Maior Valor: {1}", motormaiorvalor + 1, maiorvalor);
                        }
                        Console.ReadKey();

                        break;

                    case 4:
                        if (maiorvalor == double.MinValue)
                        {
                            Console.WriteLine("Nenhum valor foi digitado.");
                        }
                        else
                        {
                            Console.WriteLine("Motor {0} , Menor valor: {1}", motormenorvalor + 1, menorvalor);
                        }
                        Console.ReadKey();
                        break;

                        default:
                        Console.WriteLine("Muito obrigado. Até a próxima.");
                        break;



                }


            } while (opcao != 0);

        }
    }
}
