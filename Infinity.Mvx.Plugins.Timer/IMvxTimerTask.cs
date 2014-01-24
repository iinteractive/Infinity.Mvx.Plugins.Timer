using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinity.Mvx.Plugins.Timer
{
    public interface IMvxTimerTask
    {
        IMvxTimer CreateTimer(Action onTick, object state, int dueTime, int period);
    }
}
