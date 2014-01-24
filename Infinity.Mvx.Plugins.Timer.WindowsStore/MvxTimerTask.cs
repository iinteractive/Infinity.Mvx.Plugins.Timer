using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Timer.WindowsStore
{
    public class MvxTimerTask
         : IMvxTimerTask
    {
        public IMvxTimer CreateTimer(System.Action onTick, object state, int dueTime, int period)
        {
            return new MvxTimer(onTick, state, (uint)dueTime, (uint)period);
        }
    }
}
