using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Mag : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.slowTimeCount >= 5)
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
