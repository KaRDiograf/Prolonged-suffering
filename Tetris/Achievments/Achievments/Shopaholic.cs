using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public class Shopaholic : Achievment
    {
        public bool isCompleted(UserStat userStat)
        {
            if (userStat.purchaseCount >= 5)
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
