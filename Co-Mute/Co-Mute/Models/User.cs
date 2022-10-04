using System.ComponentModel.DataAnnotations;

namespace Co_Mute.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        public ICollection<Carpool> Carpools { get; set; }
       
    }
}
