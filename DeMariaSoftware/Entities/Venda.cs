using System.ComponentModel.DataAnnotations.Schema;

namespace DeMariaSoftware.Entities
{
    [Table("venda")]
    public class Venda
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        [Column("data_venda")]
        public DateTime DataVenda { get; set; }

        public Cliente Cliente { get; set; }
        public ICollection<ItensVenda> ItensVenda { get; set; }
    }
}