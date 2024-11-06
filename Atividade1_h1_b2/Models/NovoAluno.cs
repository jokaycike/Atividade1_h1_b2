using System.ComponentModel.DataAnnotations;
using Atividade1_h1_b2.Validations;

namespace Atividade1_h1_b2.Models
{
    public class NovoAluno
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Obrigatório")]

        public string telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string cpf { get; set; }
        [MaioridadeValidation(ErrorMessage = "Erro idade")]
        public int idade { get; set; }

        [MaxLength(6, ErrorMessage = "Maximo 6 letras")]
        public string RA { get; set; }

    }
}
