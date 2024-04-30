using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
                const int numeroDeVendedores = 5;
                string[] nomes = new string[numeroDeVendedores];
                decimal[] vendas = new decimal[numeroDeVendedores];
                decimal[] comissoes = new decimal[numeroDeVendedores];

                
                for (int i = 0; i < numeroDeVendedores; i++)
                {
                    Console.WriteLine($"Digite o nome do vendedor {i + 1}:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Informe o valor da sua venda {nomes[i]}:");
                    vendas[i] = decimal.Parse(Console.ReadLine());

                   
                    if (vendas[i] <= 20000)
                    {
                        comissoes[i] = vendas[i] * 0.05m; // 5%
                    }
                    else if (vendas[i] <= 40000)
                    {
                        comissoes[i] = vendas[i] * 0.06m; // 6%
                    }
                    else
                    {
                        comissoes[i] = vendas[i] * 0.07m; // 7%
                    }
                }

                
                Console.WriteLine("\nResultados das Vendas:");
                for (int i = 0; i < numeroDeVendedores; i++)
                {
                    Console.WriteLine($"{nomes[i]} - Total de Vendas: R${vendas[i]:N2}, Comissão: R${comissoes[i]:N2}");
                }

                
                Console.WriteLine("\nPressione qualquer tecla para encerrar...");
                Console.ReadKey();
            }
        }
    }
    

