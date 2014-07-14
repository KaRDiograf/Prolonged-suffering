using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Speed : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.scoresCount >= 200000)
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
