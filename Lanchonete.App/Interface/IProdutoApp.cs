using Lanchonete.app.Interface;
using System.Collections.Generic;

namespace Lanchonete.App.Interface
{
    public interface IProdutoApp : IBaseApp<Produto>
    {
        void CadastrarProdutos(List<Produto> listaProdutos);

    }
    
}
