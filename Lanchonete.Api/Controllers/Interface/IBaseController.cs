using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Lanchonete.Api.Controllers.Interface
{
    public interface IBaseController<T> where T : class
    {
        IEnumerable List();
        IActionResult Find(int id);
        IActionResult Post([FromBody]T obj);
        IActionResult Delete(int id);
    }
}
