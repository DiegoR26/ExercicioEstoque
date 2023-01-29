using System;
using System.Globalization;

namespace ExercicioEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar um produto, 2 para adicionar itens ao estoque ou 0 para sair do programa");
                string a = Console.ReadLine();

                if (a == "1")
                {

                    Console.WriteLine("Entre com os dados do produto:");
                    Console.Write("Nome: ");
                    p.Nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    p.Preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade em estoque: ");
                    p.Quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("======================================");

                    Console.WriteLine("Dados do produto: " + p);

                }
                else if (a == "0")
                {
                    Console.WriteLine("Obrigado pela preferencia!");
                    break;

                } else if (a == "2") 
                {
                    if (p.Nome == null)
                    {
                        Console.WriteLine("Você deve cadastrar um produto primeiro!");
                    }
                    else
                    {
                        Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque");
                        int qte = int.Parse(Console.ReadLine());
                        p.AdicionarProdutos(qte);

                        Console.WriteLine("Dados atualizados: " + p);
                    }

                } else
                {
                    Console.WriteLine("Comando inválido!");
                }

            }
        }
    }
}
