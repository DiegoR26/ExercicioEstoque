using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace ExercicioEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> ListaProdutos = new List<Produto>();

            Console.WriteLine("Bem-vindo ao meu sistema de estoque em CSharp!");

            while (true)
            {
                Console.WriteLine("Insira um dos comandos a seguir para prosseguir");
                Console.WriteLine("[1] Cadastrar Produto");
                Console.WriteLine("[2] Adicionar ao Estoque");
                Console.WriteLine("[3] Remover do Estoque");
                Console.WriteLine("[0] Sair");
                string a = Console.ReadLine();

                if (a == "1")
                {

                    Console.WriteLine("Entre com os dados do produto:");
                    Console.Write("Nome: ");
                    string cNome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double cPreco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade em estoque: ");
                    int cQuantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("======================================");

                    Produto p = new Produto(cNome, cPreco, cQuantidade);

                    int verificarNome = ListaProdutos.FindIndex(l => l.Nome == cNome);

                    if (verificarNome < 0)
                    {
                        ListaProdutos.Add(p);
                    }
                    else
                    {
                        Console.WriteLine("Produto já existe no cadastro!");
                    }

                    Console.WriteLine("Dados do produto: " + p);

                }

                else if (a == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("======================================");
                    Console.WriteLine("Obrigado pela preferencia!");
                    break;

                }

                else if (a == "2")
                {
                    while (true)
                    {

                        int NumeroProdutos = ListaProdutos.Count;

                        Console.WriteLine("[1] Escolher produto");
                        Console.WriteLine("[2] Listar produtos");
                        Console.WriteLine("[0] Voltar ao início");

                        string Escolha = Console.ReadLine();

                        if (Escolha == "1")
                        {
                            if (NumeroProdutos <= 0)
                            {
                                Console.WriteLine("Você deve cadastrar um produto primeiro!");
                            }

                            else
                            {
                                Console.Write("Digite o nome do Produto: ");
                                string nomeProduto = Console.ReadLine();

                                int indexNome = ListaProdutos.FindIndex(x => x.Nome == nomeProduto);

                                if (indexNome < 0)
                                {
                                    Console.WriteLine("Produto não cadastrado!");
                                }
                                else
                                {
                                    Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque");
                                    int qte = int.Parse(Console.ReadLine());

                                    if (qte == 0)
                                    {
                                        Console.WriteLine("Nenhum produto adicionado!");
                                    }
                                    else if (qte < 0)
                                    {
                                        Console.WriteLine("Você deve adicionar um valor positivo ao estoque!");
                                    }
                                    else
                                    {
                                        ListaProdutos[indexNome].AdicionarProdutos(qte);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Dados atualizados: " + ListaProdutos[indexNome]);
                                }



                            }
                        }
                        else if (Escolha == "2")
                        {
                            Console.WriteLine("Lista de Produtos:");

                            foreach (Produto produto in ListaProdutos)
                            {
                                Console.WriteLine(produto);
                            }
                            Console.WriteLine();
                            Console.WriteLine("======================================");
                        }

                        else if (Escolha == "0")
                        {
                            Console.WriteLine("De volta ao início!");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Comando inválido");
                        }
                    }

                }

                else if (a == "3")
                {
                    while (true)
                    {

                        int NumeroProdutos = ListaProdutos.Count;

                        Console.WriteLine("[1] Escolher produto");
                        Console.WriteLine("[2] Listar produtos");
                        Console.WriteLine("[0] Voltar ao início");

                        string Escolha = Console.ReadLine();

                        if (Escolha == "1")
                        {
                            if (NumeroProdutos <= 0)
                            {
                                Console.WriteLine("Você deve cadastrar um produto primeiro!");
                            }

                            else
                            {
                                Console.Write("Digite o nome do Produto: ");
                                string nomeProduto = Console.ReadLine();

                                int indexNome = ListaProdutos.FindIndex(x => x.Nome == nomeProduto);

                                if (indexNome < 0)
                                {
                                    Console.WriteLine("Produto não cadastrado!");
                                }
                                else
                                {
                                    Console.WriteLine("Digite o número de produtos a serem removidos do estoque");
                                    int qte = int.Parse(Console.ReadLine());

                                    if (qte == 0)
                                    {
                                        Console.WriteLine("Nenhum produto adicionado!");
                                    }
                                    else if (qte < 0)
                                    {
                                        Console.WriteLine("Você deve adicionar um valor positivo ao estoque!");
                                    }
                                    else if (ListaProdutos[indexNome].Quantidade < qte)
                                    {
                                        Console.WriteLine("Não há itens o suficiente para remover!");
                                        Console.WriteLine("Quantidade atual no estoque: " + ListaProdutos[indexNome].Quantidade);
                                    }
                                    else
                                    {
                                        ListaProdutos[indexNome].RemoverProdutos(qte);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Dados atualizados: " + ListaProdutos[indexNome]);
                                }



                            }
                        }
                        else if (Escolha == "2")
                        {
                            Console.WriteLine("Lista de Produtos:");

                            foreach (Produto produto in ListaProdutos)
                            {
                                Console.WriteLine(produto);
                            }
                            Console.WriteLine();
                            Console.WriteLine("======================================");
                        }

                        else if (Escolha == "0")
                        {
                            Console.WriteLine("De volta ao início!");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Comando inválido");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Comando inválido!");
                }

                Console.WriteLine(); //Espaço para não grudar

            }

        }
    }

}