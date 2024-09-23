using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FindBooks.Models
{
    public class Student
    {
        [Key] //notação chamada de "Key" 
        [DisplayName("Id")] //Notação chamda de "Id"

        //Indicando que Id vai ser uma chave Primaria na tabela "Student"
        public int Id { get; set; }
         
        [Required(ErrorMessage = "Informe o Nome")] //Quero indicar que esse campo é obrigatório
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o E-mail")] //Quero indicar que esse campo é obrigatório
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;

        public List<Subscription> Subscriptions { get; set; } = new();

    }
}
