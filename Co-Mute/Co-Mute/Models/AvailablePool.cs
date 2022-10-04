using System.ComponentModel.DataAnnotations;

namespace Co_Mute.Models
{
    public class AvailablePool
    {
        [Key]
        public int AvailablePoolId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Carpool> Carpools { get; set; }
    }
}
