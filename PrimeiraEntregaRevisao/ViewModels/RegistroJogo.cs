using System.ComponentModel.DataAnnotations;

namespace PrimeiraEntregaRevisao.Model
{
    public class RegistroJogo
    {
        [MinLength(3, ErrorMessage = "Minimo de 3 letras.")]
        [MaxLength(255, ErrorMessage = "maximo ....")]
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int PrimeiroNum { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int SegundoNum { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int TerceiroNum { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int QuartoNum { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int QuintoNum { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int SextoNum { get; set; }   
        public DateTime DataDoJogo { get; set; }
    }
}
