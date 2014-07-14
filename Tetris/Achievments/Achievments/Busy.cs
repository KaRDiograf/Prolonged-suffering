using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Busy : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.pausesCount >= 5)
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
