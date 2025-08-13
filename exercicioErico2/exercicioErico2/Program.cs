using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioErico2
{
    class Program
    {
        GerenciaProduto gerenciador = new GerenciaProduto();
        List<Produto> produtos = new List<Produto>();
        ExerciciosLinq linq = new ExerciciosLinq();
        List<int> listaInteiros = new List<int> { 1, 2, 3, 4, 5, 6 };

        static void Main(string[] args)
        {
            //Program prodMain = new Program();
            //prodMain.ExibeMenu();
            //exemplo 1:
            ExerciciosLinq linq = new ExerciciosLinq();
            List<int> listaInteiros = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> listaPares = linq.RetornaPares(listaInteiros);
            Console.WriteLine("Exemplo 1:\n");
            foreach (var p in listaPares)
            {
                Console.WriteLine(p);
            }
            
            //exemplo 2:
            List<string> nomes = new List<string> { "Erico", "Tamira", "Gabriel", "Susane" };
            List<string> nomesEmOrdem = linq.OrdenarPorNome(nomes);
            Console.WriteLine("\nExemplo 2:\n");
            foreach (var n in nomesEmOrdem)
            {
                Console.WriteLine(n);
            }

            //exemplo 3:

            Produto lapis = new Produto("Lápis", 2.50);
            Produto caneta = new Produto("Caneta", 3.50);
            Produto calculadora = new Produto("Calculadora", 15.00);
            Produto caderno = new Produto("Caderno", 15.00);

            List<Produto> listaProdutos = new List<Produto> { lapis, caneta, calculadora, caderno };
            List<string> listaNomesProdutos = linq.RetornaNomes(listaProdutos);
            List<string> listaProdutosEmOrdem = linq.OrdenarPorNome(listaNomesProdutos);
            Console.WriteLine("\nExemplo 3:\n");
            foreach (var p in listaProdutosEmOrdem)
            {
                Console.WriteLine(p);
            }

            //exemplo 4:

            List<string> produtosBaratos = linq.RetornaProdutosBaratos(listaProdutos);
            Console.WriteLine("\nExemplo 4:\n");
            foreach (var p in produtosBaratos)
            {
                Console.WriteLine(p);
            }

            //exemplo 5:


            Console.ReadKey();
        }

        public void ExibeMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nSeja bem-vindo!\n");
                Console.WriteLine("\nDigite 1 para cadastrar um novo produto;"
                    + "\nDigite 2 para listar todos os produtos;"
                    + "\nDigite 3 para filtrar os produtos por preço mínimo;"
                    + "\nDigite 4 para filtrar os produtos pelo preço máximo;"
                    + "\nDigite 5 para sair");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        gerenciador.CadastraProduto(produtos);
                        break;
                    case "2":
                        gerenciador.ListarProdutos(produtos);
                        break;
                    case "3":
                        gerenciador.FiltrarProdutosMinimo(produtos);
                        break;
                    case "4":
                        gerenciador.FiltrarProdutosMaximo(produtos);
                        break;
                    case "5":
                        continuar = gerenciador.Sair();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente!");
                        break;
                }
                if (!continuar)
                {
                    break;
                }

                while (true)
                {
                    Console.WriteLine("\nDeseja realizar outra operação? S = Sim, N = Não");
                    string desejaContinuar = Console.ReadLine();
                    if (desejaContinuar.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        break;
                    }
                    else if (desejaContinuar.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        Console.WriteLine("\nObrigado, até a próxima! Pressione qualquer tecla para sair!");
                        Console.ReadKey();
                        continuar = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Tente novamente!");
                    }
                }
            }
        }
    }
}

