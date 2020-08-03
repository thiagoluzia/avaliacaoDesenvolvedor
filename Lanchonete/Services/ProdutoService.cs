using Lanchonete.Interfaces.Repos;
using Lanchonete.Interfaces.Repos.Base;
using Lanchonete.Interfaces.Services;
using Lanchonete.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        #region Propriedades
        private readonly IProdutoRepo _repo;
        #endregion

        #region Construtores

        public ProdutoService(IProdutoRepo repo) : base(repo)
        {
            _repo = repo;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
