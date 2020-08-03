using Lanchonete.Interfaces.Domain;
using System.Collections.Generic;

namespace Lanchonete.Interfaces.Repos.Base
{
    public interface IBaseRepo<T> where T : IBaseDomain
    {
        T Find(int id);
        IList<T> List();
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}
