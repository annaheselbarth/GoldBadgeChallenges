using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengThreeBadgesLibrary
{
    public class BadgeRepo
    {
        protected readonly Dictionary<int, List<string>> _badgeRepo = new Dictionary<int, List<string>>();

        //Create
        public bool AddBadge(int id, List<string> doors)
        {
            int starting = _badgeRepo.Count();
            _badgeRepo.Add(id, doors);
            return _badgeRepo.Count() > starting;
        }

        public bool AddDoor(int badgeID, string door)
        {
            int starting = _badgeRepo[badgeID].Count();
            _badgeRepo[badgeID].Add(door);
            return _badgeRepo[badgeID].Count() > starting;
        }
        
        //Read

        public Dictionary<int, List<string>> BadgeList()
        {
            return _badgeRepo;
        }

        //Update

        public Badge BadgeID(int id)
        {
             Badge badge = new Badge();
             foreach(var keyValuePair in _badgeRepo)
            {
                if (keyValuePair.Key == id)
                {
                    badge.BadgeID = id;
                    badge.DoorAccess = keyValuePair.Value;
                    return badge;
                }
             }
            return null;
        }

        //Delete

        public bool DeleteBadge(Badge badge)
        {
            if (!_badgeRepo.ContainsKey(badge.BadgeID))
            {
                return false;
            }
            else
            {
                _badgeRepo.Remove(badge.BadgeID);
                return true;
            }
        }

        public bool DeleteDoor(int badgeID, string door)
        {
            int starting = _badgeRepo[badgeID].Count();
            _badgeRepo[badgeID].Remove(door);
            return _badgeRepo[badgeID].Count() < starting;
        }


    }
}
