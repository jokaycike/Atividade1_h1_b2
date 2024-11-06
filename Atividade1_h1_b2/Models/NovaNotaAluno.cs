using System.ComponentModel.DataAnnotations;

namespace Atividade1_h1_b2.Models
{
    public class NovaNotaAluno
    {
        [Required(ErrorMessage = "Obrigatório")]
        public string RaAluno { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string idDicipina { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public double Nota { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public double Fequencia { get; set; }
    }
}
