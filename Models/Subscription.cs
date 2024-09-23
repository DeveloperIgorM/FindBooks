using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FindBooks.Models
{
    public class Subscription
    {
        [Key] //notação chamada de "KEY" 
        [DisplayName("Id")] //Notação chamda de "ID"

        //Indicando que Id vai ser uma chave Primaria na tabela "Subscription"
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
        [DisplayName("Título")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]

        [DisplayName("Início")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Termino")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]

        public int StudentId { get; set; }  

        public Student? Student { get; set; }

    }
}
