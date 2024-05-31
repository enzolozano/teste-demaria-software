namespace DeMariaSoftware.Models
{
    public class ItensVendaResponse
    {
        public int Id { get; set; }
        public VendaResponse? Venda { get; set; }
        public ProdutoResponse? Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
