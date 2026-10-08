using System.ComponentModel.DataAnnotations;

namespace VistaProvaP1.Validations
{
    public class PosicaoValidation : ValidationAttribute
    {
        private static readonly string[] PosicoesValidas = { "GL", "ZA", "LD", "LE", "VO", "MD", "AT" };

        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return false;
            }

            string posicao = value.ToString().ToLower();
            return PosicoesValidas.Contains(posicao);
        }
    }
}