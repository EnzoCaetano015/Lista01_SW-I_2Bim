namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();
            registro.AdicionarCompra(new DateTime(2024, 5, 16), "Maçã", 5.99);
            registro.AdicionarCompra(new DateTime(2024, 5, 17), "Banana", 3.49);
            registro.AdicionarCompra(new DateTime(2024, 5, 18), "Abacaxi", 7.99);

            registro.ListarCompras();
        }
    }
}
