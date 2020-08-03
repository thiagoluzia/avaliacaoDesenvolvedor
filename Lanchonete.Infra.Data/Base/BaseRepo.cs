using Lanchonete.Infra.Data.Context;
using Lanchonete.Interfaces.Domain;
using Lanchonete.Interfaces.Repos.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.Infra.Data.Base
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseDomain
    {
        private DbContextOptions<DataContext> _options;

        public BaseRepo(DbContextOptions<DataContext> options) => _options = options;

        public virtual void Add(T obj)
        {
            using (var context = new DataContext(_options))
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }

        public virtual IList<T> List()
        {
            using (var context = new DataContext(_options))
            {
             return context.Set<T>().ToList();
            }
        }

        public virtual T Find(int id)
        {
            using (var context = new DataContext(_options))
            {
                return context.Set<T>().Find(id);
            }
        }

        public virtual void Remove(T obj)
        {
            try
            {
                using (var context = new DataContext(_options))
                {
                    context.Set<T>().Remove(obj);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException)
            {
                throw new Exception("Não foi possivel remover esse registro pois já foi utilizado.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Update(T obj)
        {
            using (var context = new DataContext(_options))
            {
                context.Set<T>().Update(obj);
                context.SaveChanges();
            }
        }

    }
}
