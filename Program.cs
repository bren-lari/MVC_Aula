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
            produto.ListarProdutos();
        }
    }
}
