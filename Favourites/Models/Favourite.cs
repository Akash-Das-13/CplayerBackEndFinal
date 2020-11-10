using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Models
{
    public class Favourite
    {
        public int FavouriteId { get; set; }
        public string Profile { get; set; }
        public string BattingStyle { get; set; }
        public string BowlingStyle { get; set; }
        public string MajorTeams { get; set; }
        public int CurrentAge { get; set; }
        public string Born { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string PlayingRole { get; set; }
        public string CreatedBy { get; set; }
    }
}
