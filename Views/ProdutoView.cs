using System;
using System.Collections.Generic;
using MVC_Aula.Model.Model;

namespace MVC_Aula.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)

            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

            public Produto CadastrarProduto(){


                Produto pro = new Produto();

                Console.Write($"Insira o código do produto: ");
                pro.Codigo = int.Parse(Console.ReadLine());

                Console.Write($"Insira o nome do produto: ");
                pro.Nome = Console.ReadLine();
                
                Console.Write($"Insira o preço do produto: ");
                pro.Preco = float.Parse(Console.ReadLine());

                return pro;
 
            }
        }
    }