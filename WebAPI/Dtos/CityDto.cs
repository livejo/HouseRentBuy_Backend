using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Name is mandatory Field")] //input validation
        [StringLength(50,MinimumLength =3)]
        // [RegularExpression(".*[a-zA-Z)+.*", ErrorMessage = ""] -> custom validators
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is mandatory Field")]
        public string Country { get; set; }
    }
}
 