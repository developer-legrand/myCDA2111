using ApiCereals.Migrations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiCereals.Models
{

    [Table("kellogg")]
    public class Cereal
    {
        // en C# les annotations se mettent en crochet
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Name")]
        //[MinLength(2, ErrorMessage = "")]
        //[MaxLength(50)]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[^_]{2,50}$", ErrorMessage = "ERROR FORMAT")]
        public string Name { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Calories")]
        [Comment("this is a comment for kellogg.Calories")] // add comment to the column
        [Range(-1, 500)]
        public int Calories { get; set; }


        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Protein_different")] // use when name column different of attributes
        [Range(-1, 500)]
        public int Protein { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Sodium")]
        [Range(-1, 500)]
        public int Sodium { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Fiber")]
        [Range(-1, 500)]
        public int Fiber { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Carbo")]
        [Range(-1, 500)]
        public int Carbo { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Sugars")]
        [Range(-1, 500)]
        public int Sugars { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Potass")]
        [Range(-1, 500)]
        public int Potass { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Vitamins")]
        [Range(-1, 500)]
        public int Vitamins { get; set; }

        [Required(ErrorMessage = "DATA RECQUIRED")]
        [Column("Rating", TypeName = "decimal(5, 2)")]
        [Range(0.00,100.00)]
        public decimal Rating { get; set; }

    }

}
