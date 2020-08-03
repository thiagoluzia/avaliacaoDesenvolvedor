using Lanchonete.app.Base;
using Lanchonete.App.Interface;
using Lanchonete.Interfaces.Services;
using System.Collections.Generic;

namespace Lanchonete.App
{
    public class ProdutoApp : BaseApp<Produto>, IProdutoApp
    {
        #region Propriedades
        private readonly IProdutoService _service;
        #endregion
         
        #region Construtor

        public ProdutoApp(IProdutoService service) : base(service)
        {
            _service = service;
        }


        #endregion

        #region Metodos
        public void CadastrarProdutos(List<Produto> listaProdutos)
        {
            foreach (var item in listaProdutos)
            {
                _service.Save(item);
            }
        }
        #endregion
    }
}
