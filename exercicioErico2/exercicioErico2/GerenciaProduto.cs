using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioErico2
{
    public class GerenciaProduto
    {
        public void CadastraProduto(List<Produto> produtos)
        {
            Console.WriteLine("\nDigite o nome do produto que deseja cadastrar: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nAgora, digite o valor do produto: ");
            string valor = Console.ReadLine();
            try
            {
                double valorDouble = double.Parse(valor);
                Produto produto = new Produto(nome, valorDouble);
                produtos.Add(produto);
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nO valor cadastrado é inválido, tente novamente!");
            }
        }

        public void ListarProdutos(List<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("\nAbaixo, a lista de produtos cadastrados:\n");
                foreach (var produto in produtos)
                {
                    string valorFormatado = produto.valor.ToString("F2");
                    Console.WriteLine($"{produto.nome} - R$ {valorFormatado}");
                }
            }
            else
            {
                Console.WriteLine("Ainda não há nenhum produto cadastrado!");
            }
        }

        public void FiltrarProdutosMinimo(List<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("\nDigite o valor mínimo para a pesquisa de produtos:");
                string valorMinimo = Console.ReadLine();
                try
                {
                    double minDouble = double.Parse(valorMinimo);

                    if (produtos.Any(p => p.valor > minDouble))
                    {
                        Console.WriteLine($"Lista de produtos com o preço maior que R$ {minDouble.ToString("F2")}:\n");
                        foreach (var produto in produtos)
                        {
                            if (minDouble <= produto.valor)
                            {
                                string valorFormatado = produto.valor.ToString("F2");
                                Console.WriteLine($"{produto.nome} - R$ {valorFormatado}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não há nenhum produto com o valor acima do digitado!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Não foi possível realizar a pesquisa. Verifique se o valor digitado é válido!");
                }
            }
            else
            {
                Console.WriteLine("Ainda não há nenhum produto cadastrado!");
            }

        }

        public void FiltrarProdutosMaximo(List<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("\nDigite o limite máximo de valor para a pesquisa de produtos:");
                string valorMaximo = Console.ReadLine();
                try
                {
                    double maxDouble = double.Parse(valorMaximo);

                    if (produtos.Any(p => p.valor < maxDouble))
                    {
                        Console.WriteLine($"Lista de produtos com o preço menor que R$ {maxDouble.ToString("F2")}:\n");
                        foreach (var produto in produtos)
                        {
                            if(maxDouble >= produto.valor)
                            {
                                string valorFormatado = produto.valor.ToString("F2");
                                Console.WriteLine($"{produto.nome} - R$ {valorFormatado}");
                            }
                          
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não há nenhum produto com o valor abaixo do digitado!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Não foi possível realizar a pesquisa. Verifique se o valor digitado é válido!");
                }
            }
            else
            {
                Console.WriteLine("Ainda não há nenhum produto cadastrado!");
            }
        }

        public bool Sair()
        {
            Console.WriteLine("Obrigado, até a próxima!");
            Console.WriteLine("Digite qualquer tecla para sair.");
            Console.ReadKey();
            return false;
        }
    }

}
