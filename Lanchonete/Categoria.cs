
using System.Collections;
using System.Collections.Generic;

namespace Lanchonete
{
    public class Categoria : BaseDomain
    {

        #region Propriedades

        public string Nome { get; set; }

        public virtual IList<Produto> Produtos { get; set; }
        #endregion

        #region Constructores
        protected Categoria() { }

        public Categoria(string nome)
        {
            Nome = nome;
        }
        #endregion
    }
}
