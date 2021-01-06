using System;
using MVC_Aula.Model.Model;

namespace MVC_Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ProdutoController produto = new ProdutoController();
            produto.Cadastrar();
            Console.WriteLine($"\r\n--- Produtos Cadastrados ---\r\n");
            produto.ListarProdutos();
        }
    }
}
