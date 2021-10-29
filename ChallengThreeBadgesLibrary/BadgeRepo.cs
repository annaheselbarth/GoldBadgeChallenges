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

        public bool AddBadge(int id, List<string> doors)
        {
            int starting = _badgeRepo.Count();
            _badgeRepo.Add(id, doors);
            return _badgeRepo.Count() > starting;
        }
        
    }
}
