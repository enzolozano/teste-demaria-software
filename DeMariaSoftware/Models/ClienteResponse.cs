using System.ComponentModel.DataAnnotations;

namespace DeMariaSoftware.Models
{
    public class ClienteResponse
    {
        [Display(Name = "Id", Description = "Identificador único do cliente")]
        public int Id { get; set; }

        [Display(Name = "Nome", Description = "Nome do cliente")]
        public string Nome { get; set; }

        [Display(Name = "Endereço", Description = "Endereço do cliente")]
        public string Endereco { get; set; }

        [Display(Name = "Telefone", Description = "Telefone do cliente")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail", Description = "E-mail do cliente")]
        public string Email { get; set; }
    }
}
