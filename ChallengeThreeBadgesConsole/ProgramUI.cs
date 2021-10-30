using ChallengThreeBadgesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeBadgesConsole
{
    class ProgramUI
    {
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();

        public void Run()
        {
            SeedBadgeList();
            RunMenu();
        }

        public void RunMenu()
        {

        }

        public void SeedBadgeList()
        {

        }
    }
}
