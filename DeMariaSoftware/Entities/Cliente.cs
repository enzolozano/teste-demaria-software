using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeMariaSoftware.Entities
{
    [Table("cliente")]
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Column("endereco")]
        [MaxLength(255)]
        public string Endereco { get; set; }

        [Column("telefone")]
        [MaxLength(20)]
        public string Telefone { get; set; }

        [Column("email")]
        [MaxLength(100)]
        public string Email { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}