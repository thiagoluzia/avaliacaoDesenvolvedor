using Lanchonete.Infra.Data.Base;
using Lanchonete.Infra.Data.Context;
using Lanchonete.Interfaces.Repos;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.Infra.Data
{
    public class CategoriaRepo : BaseRepo<Categoria>, ICategoriaRepo
    {
        //A implementação da Classe,  Implementa o base da camada,  e  a interface dela propria
        public CategoriaRepo(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
