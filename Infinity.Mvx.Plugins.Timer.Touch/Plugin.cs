using Cirrious.CrossCore;
using Cirrious.CrossCore.Converters;
using Cirrious.CrossCore.Plugins;

namespace Infinity.Mvx.Plugins.Timer.Touch
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Cirrious.CrossCore.Mvx.RegisterType<IMvxTimerTask, MvxTimerTask>();
            Cirrious.CrossCore.Mvx.CallbackWhenRegistered<IMvxValueConverterRegistry>(RegisterValueConverter);
        }

        private void RegisterValueConverter()
        {
            Cirrious.CrossCore.Mvx.Resolve<IMvxValueConverterRegistry>().AddOrOverwriteFrom(GetType().Assembly);
        }
    }
}