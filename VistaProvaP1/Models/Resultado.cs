using System.ComponentModel.DataAnnotations;

namespace VistaProvaP1.Models
{
    public class Resultado
    {
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string Cpf { get; set; }

        public bool Aprovado { get; set; }
    }
}