using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lanchonete.Api.Controllers.Interface;
using Lanchonete.Api.ViewModels;
using Lanchonete.App.DTOS;
using Lanchonete.App.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.Api.Controllers
{

    [Route("categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase, IBaseController<Categoria>
    {
        #region Propriedades
        private readonly ICategoriaApp _categoriaApp;

        public CategoriaController(ICategoriaApp categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }
        #endregion

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoriaApp.Remove(id);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Find(int id)
        {
            _categoriaApp.Find(id);

            return Ok();
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<CategoriaViewModel>> List()
        //{
        //    return _categoriaApp.List();
        //}

       [HttpGet]
        public IEnumerable<Categoria> List()
        {
            return _categoriaApp.List();
        }

        [HttpPost]
        public ActionResult<CategoriaViewModel> Post([FromBody] CategoriaDTO dto)
        {
            var categoria = new Categoria(dto.Nome);
            _categoriaApp.Save(categoria);
            return Ok("Categoria salva com sucesso");
        }

        public IActionResult Post([FromBody] Categoria obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable IBaseController<Categoria>.List()
        {
            throw new NotImplementedException();
        }

    }
}
