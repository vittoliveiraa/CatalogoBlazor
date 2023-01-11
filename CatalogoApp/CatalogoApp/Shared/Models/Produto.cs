using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoApp.Shared.Models
{
    public class Produto
    {
        
        public int ProdutoId { get; set; }
        [MaxLength(100)]
        public string NomeProduto { get; set; }
        [MaxLength(200)]
        public string DescricaoProduto { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        public decimal Preco { get; set; }
        [MaxLength(250)]
        public string ImagemUrl { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
