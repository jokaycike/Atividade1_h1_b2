using System.ComponentModel.DataAnnotations;

namespace Atividade1_h1_b2.Models
{
    public class NovaDisciplina
    {

        [Required(ErrorMessage = "Obrigatório")]
        public string IdDisciplina { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Curso { get; set; }
    }
}
