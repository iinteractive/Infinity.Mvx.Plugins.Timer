using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Converters;
using Cirrious.CrossCore.Plugins;

namespace Infinity.Mvx.Plugins.Timer.WindowsStore
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
