namespace DeMariaSoftware.Models
{
    public class VendaResponse
    {
        public int Id { get; set; }
        public ClienteResponse? Cliente { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
