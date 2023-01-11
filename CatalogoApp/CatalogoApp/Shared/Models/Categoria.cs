using System.ComponentModel.DataAnnotations;

namespace CatalogoApp.Shared.Models
{
    public class Categoria
    {
        [MaxLength(100)]
        public int CategoriaId { get; set; }
        [MaxLength(200)]
        public string Nome { get; set; }
        public string DescricaoCategoria { get; set; }

        public ICollection<Produto> Produtos { get; set; }

    }
}
