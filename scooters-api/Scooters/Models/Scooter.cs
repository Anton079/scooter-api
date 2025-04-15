using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace scooter_api.Scooters.Models
{
    [Table("scooter")]
    public class Scooter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("brand")]
        public string brand { get; set; }

        [Required]
        [Column("modelType")]
        public string modelType { get; set; }

        [Required]
        [Column("horsePower")]
        public int horsePower { get; set; }

        [Required]
        [Column("range")]
        public int range { get; set; }

        [Required]
        [Column("maxSpeed")]
        public int maxSpeed { get; set; }
    }
}
