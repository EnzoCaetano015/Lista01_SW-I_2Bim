using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque
{
    class Produto
    {
        // Atributos
        private string nome;
        private double preco;
        private int quantidadeEmEstoque;

        // Construtor
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar itens ao estoque
        public void AdicionarItemEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                quantidadeEmEstoque += quantidade;
                Console.WriteLine($"{quantidade} {nome}(s) adicionado(s) ao estoque.");
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Nenhum item adicionado ao estoque.");
            }
        }

        // Método para remover itens do estoque
        public void RemoverItemEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= quantidadeEmEstoque)
            {
                quantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} {nome}(s) removido(s) do estoque.");
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Nenhum item removido do estoque.");
            }
        }

        // Método para exibir informações do produto
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: R${preco:F2}");
            Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
        }
    }
}
