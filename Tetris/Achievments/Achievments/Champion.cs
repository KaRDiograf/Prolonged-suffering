using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Champion : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.playerPosition == 0)
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
