using System;
using System.ComponentModel.DataAnnotations;

namespace DoJoSaque.Models
{
    public class SaqueModel
    {
        // Valor do saque
        [Display(Name = "Saque")]
        [Required(ErrorMessage = "Digite o valor do saque.")]
        [DataType(DataType.Currency)]
        [Range(10.0, Double.MaxValue, ErrorMessage = "Digite no mínimo R$10.")]
        public Decimal valorSaque { get; set;}
    }
}
