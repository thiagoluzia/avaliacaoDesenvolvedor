using Lanchonete.app.Interface;
using Lanchonete.Interfaces.Domain;
using Lanchonete.Interfaces.Services;
using System.Collections.Generic;

namespace Lanchonete.app.Base
{
    public class BaseApp<T> : IBaseApp<T> where T : class, IBaseDomain
    {
        #region Properties
        private readonly IBaseService<T> _service;
        #endregion

        #region Constructors
        public BaseApp(IBaseService<T> service) => _service = service;
        #endregion

        #region Methods
        public virtual T Find(int id) => _service.Find(id);

        public virtual IList<T> List() => _service.List();

        public virtual void Remove(int id) => _service.Remove(id);

        public virtual int Save(T obj) => _service.Save(obj);
        #endregion
    }
}
