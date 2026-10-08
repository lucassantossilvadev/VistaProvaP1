using System.ComponentModel.DataAnnotations;
using VistaProvaP1.Validations;

namespace VistaProvaP1.Models
{
    public class Jogador
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [StringLength(500, ErrorMessage = "Descrição deve ter no máximo 500 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Posição é obrigatória")]
        [PosicaoValidation(ErrorMessage = "Posição inválida ! Use: GL, ZA, LD, LE, VO, MD ou AT")]
        public string Posicao { get; set; }
    }
}