using Lanchonete.Infra.Data.Base;
using Lanchonete.Infra.Data.Context;
using Lanchonete.Interfaces.Repos;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.Infra.Data
{
    public class ProdutoRepo : BaseRepo<Produto>, IProdutoRepo
    {
        public ProdutoRepo(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
