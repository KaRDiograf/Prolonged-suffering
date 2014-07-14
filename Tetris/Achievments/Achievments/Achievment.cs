using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achievments
{
    public interface Achievment
    {
        bool isCompleted(UserStat userStat);
    }
}
