using System.ComponentModel.DataAnnotations;

namespace Practice_pro_CFA.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string Name { get; set; }
        [Range(18, 25, ErrorMessage = "Enter age between 18 to 25")]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
