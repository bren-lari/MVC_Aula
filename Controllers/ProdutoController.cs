using MVC_Aula.Model.Model;
using MVC_Aula.Views;

namespace MVC_Aula
{
    internal class ProdutoController
    {
        Produto produto = new Produto();  
      ProdutoView produtoView = new ProdutoView();

      public void ListarProdutos()
      {
          produtoView.Listar(produto.Ler());
      }
      
      public void Cadastrar(){
          produto.InserirProduto (produtoView.CadastrarProduto());
      }
    }
}