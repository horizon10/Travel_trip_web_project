using System.ComponentModel.DataAnnotations;

namespace TravelTripMVCProject.Models.Classes
{
    public class MainPage
    {
        [Key]
        public int ID{ get; set; }
        public string Baslik{ get; set; }
        public string Aciklama {  get; set; }
    }
}
