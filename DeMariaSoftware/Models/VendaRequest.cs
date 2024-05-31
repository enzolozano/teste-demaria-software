namespace DeMariaSoftware.Models
{
    public class VendaRequest
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? DataVenda { get; set; }
    }
}
