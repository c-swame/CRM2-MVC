using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM2_MVC.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }

        [Required, MinLength(1)]
        [Column(TypeName = "varchar(100)")]
        public string CourseName { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int DurationInHours { get; set; }

        public ICollection<LeadModel> Leads { get; set; } = default;

        /* !!!!! a implementar
        [Required]
        public string TotalPLaces { get; set; }
        [Required]
        public string AvaliablelPLaces { get; set; }
        */
    }
}
