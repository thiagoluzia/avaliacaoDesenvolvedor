using Lanchonete.Interfaces.Domain;
using System.Collections.Generic;

namespace Lanchonete.app.Interface
{
    public interface IBaseApp<T> where T : IBaseDomain
    {
        T Find(int id);
        IList<T> List();
        int Save(T obj);
        void Remove(int id);
    }
}
