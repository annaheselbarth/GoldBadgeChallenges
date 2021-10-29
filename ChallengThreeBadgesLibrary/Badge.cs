using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengThreeBadgesLibrary
{
    public class Badge
    {
        public Badge()
        {

        }

        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }
        public Badge(int id)
        {
            BadgeID = id;
        }
        public Badge(int id, List<string> door)
        {
            BadgeID = id;
            DoorAccess = door;
        }

    }
}
