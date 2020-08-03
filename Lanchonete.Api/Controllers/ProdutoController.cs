

using Lanchonete.Api.Controllers.Interface;
using Lanchonete.App.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lanchonete.Api.Controllers
{
    [Route("produto")]
    public class ProdutoController : ControllerBase, IBaseController<Produto>
    {
        private readonly IProdutoApp _produtoApp;

        public ProdutoController(IProdutoApp produtoApp)
        {
            _produtoApp = produtoApp;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto obj)
        {
            try
            {
                return Ok(_produtoApp.Save(obj));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpPost, Route("cadastrar-lista")]
        public IActionResult CadastrarProdutos([FromBody] List<Produto> listProdutos)
        {
            try
            {
                _produtoApp.CadastrarProdutos(listProdutos);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _produtoApp.Remove(id);
                return Ok("Item deletado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Find(int id)
        {
            return Ok(_produtoApp.Find(id));
        }

        [HttpGet]
        public IEnumerable List()
        {
            return _produtoApp.List();
        }
    }
}
