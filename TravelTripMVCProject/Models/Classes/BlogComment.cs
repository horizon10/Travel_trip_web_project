
using System.Collections.Generic;

namespace TravelTripMVCProject.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> Deger1 { get; set; } = new List<Blog>();
        public IEnumerable<Comments> Deger2 { get; set; } = new List<Comments>();
        public IEnumerable<Blog> Deger3 { get; set; } = new List<Blog>();
    }

}
