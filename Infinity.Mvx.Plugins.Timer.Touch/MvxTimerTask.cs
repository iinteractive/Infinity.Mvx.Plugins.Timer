
using Cirrious.CrossCore.Touch.Platform;
using MonoTouch.Foundation;

namespace Infinity.Mvx.Plugins.Timer.Touch
{
    public class MvxTimerTask
         : MvxTouchTask, IMvxTimerTask
    {
        public IMvxTimer CreateTimer(System.Action onTick, object state, int dueTime, int period)
        {
            return new MvxTimer(onTick, state, (uint)dueTime, (uint)period);
        }
    }
}