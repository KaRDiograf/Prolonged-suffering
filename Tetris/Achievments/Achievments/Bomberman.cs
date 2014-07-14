using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Bomberman : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.bombsCount >= 5)
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
