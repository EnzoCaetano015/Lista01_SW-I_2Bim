namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Produto
            Produto produto1 = new Produto("Caneta", 2.50, 10);
            produto1.ExibirInformacoes();

            produto1.AdicionarItemEstoque(5);
            produto1.ExibirInformacoes();

            produto1.RemoverItemEstoque(3);
            produto1.ExibirInformacoes();
        }
    }
}
