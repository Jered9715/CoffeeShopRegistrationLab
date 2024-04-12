using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models
{
    public class User
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is needed")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of Birth is needed")]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage ="Password is needed")]
        public string Password { get; set; }



    }
}
