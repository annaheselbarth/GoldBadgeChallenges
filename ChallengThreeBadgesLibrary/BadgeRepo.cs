using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengThreeBadgesLibrary
{
    public class BadgeRepo
    {
        protected readonly Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();

        //Create
        public bool AddBadge(int id, List<string> doors)
        {
            int starting = _badgeDictionary.Count();
            _badgeDictionary.Add(id, doors);
            return _badgeDictionary.Count() > starting;
        }

        public bool AddDoor(int badgeID, string door)
        {
            int starting = _badgeDictionary[badgeID].Count();
            _badgeDictionary[badgeID].Add(door);
            return _badgeDictionary[badgeID].Count() > starting;
        }
        
        //Read

        public Dictionary<int, List<string>> GetBadgeDictionary()
        {
            return _badgeDictionary;
        }

        //Update

        public Badge BadgeID(int id)
        {
             Badge badge = new Badge();
             foreach(var keyValuePair in _badgeDictionary)
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
            if (!_badgeDictionary.ContainsKey(badge.BadgeID))
            {
                return false;
            }
            else
            {
                _badgeDictionary.Remove(badge.BadgeID);
                return true;
            }
        }

        public bool DeleteDoor(int badgeID, string door)
        {
            int starting = _badgeDictionary[badgeID].Count();
            _badgeDictionary[badgeID].Remove(door);
            return _badgeDictionary[badgeID].Count() < starting;
        }


    }
}
