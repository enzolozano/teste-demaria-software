namespace DeMariaSoftware.Models
{
    public class ProdutoRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Estoque { get; set; }
    }
}
