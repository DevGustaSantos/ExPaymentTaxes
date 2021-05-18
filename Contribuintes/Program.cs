using System;
using System.Globalization;
using System.Collections.Generic;
using Contribuintes.Entites;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa....");

            Console.Write("Entre com o numero de pagadores de taxa...: ");
            int n = int.Parse(Console.ReadLine());
            List<Contribuinte> contribuintes = new List<Contribuinte>();


            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(); //Pular uma linha na execução do código.
                Console.WriteLine($"Dados do #{i}º pagador...");
                Console.Write("Pessoa Fisica ou Juridica(f/j)?...: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome...: ");
                string nome = Console.ReadLine();
                Console.Write("Gasto Anual...: ");
                double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (ch)
                {
                    case 'f':
                        {
                            Console.Write("Gastos com saúde...: ");
                            double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contribuintes.Add(new PessoaFisica(nome,gastos,saude));
                            break;
                        }
                    case 'j':
                        {
                            Console.Write("Quantidade de funcionarios...: ");
                            int qtdFuncionario = int.Parse(Console.ReadLine());
                            contribuintes.Add(new PessoaJuridica(nome, gastos, qtdFuncionario));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Escolha invalida");
                            break;
                        }
                }
            }

            Console.WriteLine();//Pula uma linha na execução.
            Console.WriteLine("Taxas Pagas...:");
            double soma = 0;
            foreach (Contribuinte cont in contribuintes)
            {
                soma += cont.Impostos();
                Console.WriteLine($"{cont.Name}: ${cont.Impostos().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();//Pula uma linha na execução...
            Console.WriteLine($"Total das taxas...: {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
