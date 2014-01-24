using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Timer.WindowsStore
{
    public class MvxTimer
        : IMvxTimer
    {
        private System.Threading.Timer _timer;
        private Action _action;
        internal MvxTimer(Action action, object state, uint dueTime, uint period)
        {
            _action = action;
            _timer = new System.Threading.Timer(new System.Threading.TimerCallback(Tick), state, (int)dueTime, (int)period);
        }

        private void Tick(object state)
        {
            _action();
        }
    }
}
