using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeMariaSoftware.Entities
{
    [Table("produto")]
    public class Produto
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("preco")]
        public decimal Preco { get; set; }
        [Column("estoque")]
        public int Estoque { get; set; }

        public ICollection<ItensVenda> ItensVenda { get; set; }
    }
}