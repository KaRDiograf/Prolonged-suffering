using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Destroyer : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.removingCount >= 5)
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
