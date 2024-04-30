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
     
                const int ndevendedores = 5;
                string[] nomes = new string[ndevendedores];
                decimal[] vendas = new decimal[ndevendedores];
                decimal[] comissoes = new decimal[ndevendedores];

                
                for (int i = 0; i < ndevendedores; i++)
                {
                    Console.WriteLine($"Digite o nome do vendedor {i + 1}:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Informe o valor da sua venda {nomes[i]}:");
                    vendas[i] = decimal.Parse(Console.ReadLine());

                   
                    if (vendas[i] <= 20000)
                    {
                        comissoes[i] = vendas[i] * 0.05m; 
                    }
                    else if (vendas[i] <= 40000)
                    {
                        comissoes[i] = vendas[i] * 0.06m; 
                    }
                    else
                    {
                        comissoes[i] = vendas[i] * 0.07m; 
                    }
                }

                
                Console.WriteLine($"Resultados das Vendas:");
                for (int i = 0; i < ndevendedores; i++)
                {
                    Console.WriteLine($"{nomes[i]} - Total de Vendas: R${vendas[i]:N2}, Comissão: R${comissoes[i]:N2}");
                }

                Console.ReadKey();
            }
        }
    }
    

