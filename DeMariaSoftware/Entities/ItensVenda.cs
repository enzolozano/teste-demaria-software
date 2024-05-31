using System.ComponentModel.DataAnnotations.Schema;

namespace DeMariaSoftware.Entities
{
    [Table("itens_venda")]
    public class ItensVenda
    {
        [Column("id")]
        public int Id {  get; set; }
        [Column("venda_id")]
        public int VendaId { get; set; }
        [Column("produto_id")]
        public int ProdutoId { get; set; }
        [Column("quantidade")]
        public int Quantidade { get; set; }
        [Column("preco_unitario")]
        public decimal PrecoUnitario { get; set; }

        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
