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
        public Decimal valorSaque { get; set;}
    }
}
