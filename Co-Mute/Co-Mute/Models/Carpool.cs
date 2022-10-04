using System.ComponentModel.DataAnnotations;

namespace Co_Mute.Models
{
    public class Carpool
    {

        [Key]
        public int CarpoolID { get; set; }
        
        public int UserID { get; set; }
        
        public int PoolID { get; set; }
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Departure Time is required")]
        public String DepartureTime { get; set; }
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Expected Arrival Time is required")]
        public String ExpectedArrivalTime { get; set; }
        [Required(ErrorMessage = "Origin is required")]
        public String Origin { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Days Available is required")]
        public int DaysAvailable { get; set; }
        [Required(ErrorMessage = "Destination is required")]
        public String Destination { get; set; }
        [Required(ErrorMessage = "Available Seats is required")]
        [DataType(DataType.PhoneNumber)]
        public int AvailableSeats { get; set; }
        [Required(ErrorMessage = "Owner is required")]
        public String Owner { get; set; }
        [DataType(DataType.MultilineText)]

        public String Notes { get; set; }


        public AvailablePool AvailablePool{ get; set; }
        public User User { get; set; }
    }
}
