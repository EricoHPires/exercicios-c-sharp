using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioErico2
{
    public class Produto
    {
        public string nome { get; set; }
        public double valor { get; set; }

        public Produto(string nome, double valor)
        {
            this.nome = nome;
            if (valor < 0)
            {
                throw new Exception("O valor não pode ser negativo!");
            }
            this.valor = valor;
        }
    }
}
