namespace Lanchonete
{
    public class Produto : BaseDomain
    {
        public int Categoria_Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
