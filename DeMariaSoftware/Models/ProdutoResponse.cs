using System.ComponentModel.DataAnnotations;

namespace DeMariaSoftware.Models
{
    public class ProdutoResponse
    {
        [Display(Name = "ID", Description = "Identificador próprio do produto")]
        public int Id { get; set; }

        [Display(Name = "Nome", Description = "Nome do produto")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Description = "Descrição breve do produto")]
        public string Descricao { get; set; }

        [Display(Name = "Preço", Description = "Preço em reais do produto")]
        public decimal Preco { get; set; }

        [Display(Name = "Estoque", Description = "Quantidade do produto presente no estoque")]
        public int Estoque { get; set; }
    }
}