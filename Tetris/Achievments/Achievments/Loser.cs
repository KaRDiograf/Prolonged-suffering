using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Loser : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.scoresCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
