using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using StringLengthAttribute = System.ComponentModel.DataAnnotations.StringLengthAttribute;

namespace CRM2_MVC.Models
{
    public class LeadModel
    {
        [Key]
        public int LeadId { get; set; }

        [Required, MinLength(1)]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Unique]
        public string Email { get; set; }

        [Required]
        [Unique]
        // !!!!! acredito que parte das restrições não estão sendo aplicadas!! Pode ser por ser um sql server e n sql? Lógica de model vs de migration?
        [Column(TypeName = "varchar(11)")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O CPF deve possuir apenas uma sequencia de algarismos arábicos (0-9)")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Precisa ter exatamente 11 caracteres. Adicione apenas números")]
        public string Cpf { get; set; }

        public ICollection<CourseModel> Courses { get; set; } = default;
    }
}
