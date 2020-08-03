using Lanchonete.Interfaces.Repos;
using Lanchonete.Interfaces.Repos.Base;
using Lanchonete.Interfaces.Services;
using Lanchonete.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Services
{
    public class CategoriaService : BaseService<Categoria>, ICategoriaService
    {
        #region Propriedades
        private readonly ICategoriaRepo _repo;
        #endregion

        #region Construtores

        public CategoriaService(ICategoriaRepo repo) : base(repo)
        {
            _repo = repo;
        }
        #endregion
    }
}
