using Lanchonete.Interfaces.Domain;
using Lanchonete.Interfaces.Repos.Base;
using Lanchonete.Interfaces.Services;
using System.Collections.Generic;

namespace Lanchonete.Services.Base
{

    public class BaseService<T> : IBaseService<T> where T : IBaseDomain
    {
        #region Properties
        private readonly IBaseRepo<T> _repo;
        #endregion

        #region Constructors
        public BaseService(IBaseRepo<T> repo) => _repo = repo;
        #endregion

        #region Methods
        public virtual T Find(int id) => _repo.Find(id);

        public virtual IList<T> List() => _repo.List();

        public virtual void Remove(int id)
        {
            var obj = Find(id);
            _repo.Remove(obj);
        }

        protected virtual void Add(T obj)
        {
            _repo.Add(obj);
        }

        protected virtual void Update(T obj)
        {
            _repo.Update(obj);
        }

        public virtual int Save(T obj)
        {
            if (obj.Id == 0)
                Add(obj);
            else
                Update(obj);

            return obj.Id;

        }
        #endregion
    }
}