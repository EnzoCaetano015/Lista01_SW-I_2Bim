﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    class RegistroDeCompras
    {
        // Definindo uma estrutura para representar uma compra
        struct Compra
        {
            public DateTime data;
            public string produto;
            public double valor;

            public Compra(DateTime data, string produto, double valor)
            {
                this.data = data;
                this.produto = produto;
                this.valor = valor;
            }
        }

        // Lista para armazenar as compras
        private List<Compra> compras;

        // Construtor
        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        // Método para adicionar uma compra
        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            Compra novaCompra = new Compra(data, produto, valor);
            compras.Add(novaCompra);
            Console.WriteLine("Compra registrada com sucesso!");
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            Console.WriteLine("Lista de Compras:");

            foreach (Compra compra in compras)
            {
                Console.WriteLine($"Data: {compra.data.ToShortDateString()} | Produto: {compra.produto} | Valor: R${compra.valor:F2}");
            }
        }
    }
}
