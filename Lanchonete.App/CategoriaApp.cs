using Lanchonete.app.Base;
using Lanchonete.App.Interface;
using Lanchonete.Interfaces.Services;


namespace Lanchonete.App
{
    public class CategoriaApp : BaseApp<Categoria>, ICategoriaApp
    {
        private readonly ICategoriaService _service;

        public CategoriaApp(ICategoriaService service) : base(service)
        {
            _service = service;
        }
    }
}
