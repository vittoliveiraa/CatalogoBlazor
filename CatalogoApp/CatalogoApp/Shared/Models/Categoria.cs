using System.ComponentModel.DataAnnotations;

namespace CatalogoApp.Shared.Models
{
    public class Categoria
    {
        
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O nome da Categoria é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição da categoria é obrigatória")]
        [MaxLength(200)]
        public string DescricaoCategoria { get; set; }

        public ICollection<Produto> Produtos { get; set; }

    }
}
