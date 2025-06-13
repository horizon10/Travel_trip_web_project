using System.ComponentModel.DataAnnotations;

namespace TravelTripMVCProject.Models.Classes
{
    public class AboutMe
    {
        [Key]
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}
