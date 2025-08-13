using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioErico2
{
    public class ExerciciosLinq
    {
        //exemplo 1: criar uma lista de inteiros e retornar apenas os números pares.
        
        public List<int> RetornaPares(List<int> listaCompleta)
        {
            var pares = listaCompleta.Where(n => n % 2 == 0);
            List<int> listaPares = pares.ToList();
            return listaPares;
        }

        //exemplo 2: criar uma lista de strings e ordenar alfabeticamente.

        public List<string> OrdenarPorNome(List<string> listaNomes)
        {
            var listaOrdenada = listaNomes.OrderBy(n => n);
            List<string> nomesEmOrdem = listaOrdenada.ToList();
            return nomesEmOrdem;
        }

        //exemplo 3: selecionar campos específicos com Select:

        public List<string> RetornaNomes (List<Produto> produtos)
        {
            var nomesProdutos = produtos.Select(p => p.nome);
            List<string> listaNomesProdutos = nomesProdutos.ToList();
            return listaNomesProdutos;
        }

        //exemplo 4: agrupar filtros e seleções:

        public List<string> RetornaProdutosBaratos (List<Produto> produtos)
        {
            var produtosBaratos = produtos.Where(p => p.valor < 5)
                .Select(p => p.nome)
                .OrderBy(p => p);
            List<string> listaNomesProdutosBaratos = produtosBaratos.ToList();
            return listaNomesProdutosBaratos;
        }

        //exemplo 5: agrupar produtos com preço igual e converter em Dictionary:

        public Dictionary<double, List<Produto>> AgruparPorPreco (List<Produto> produtos)
        {
            var produtosPorPreco = produtos.GroupBy(p => p.valor);
            Dictionary<double, List <Produto>> produtosComMesmoPreco = produtosPorPreco.ToDictionary(grupo => grupo.Key, grupo => grupo.ToList());
            return produtosComMesmoPreco;
        }


    }
}
