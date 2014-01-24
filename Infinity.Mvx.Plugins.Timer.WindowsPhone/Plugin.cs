using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore.Plugins;

namespace Infinity.Mvx.Plugins.Timer.WindowsPhone
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Cirrious.CrossCore.Mvx.RegisterType<IMvxTimerTask, MvxTimerTask>();
        }
    }
}
