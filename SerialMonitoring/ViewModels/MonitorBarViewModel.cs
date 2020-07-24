using SerialMonitoring.Common;
using SerialMonitoring.ViewModels.Entity;

namespace SerialMonitoring.ViewModels
{
    class MonitorBarViewModel : MonitorViewModel
    {
        public MonitorBarViewModel() : base()
        {
            var monitors = ChannelManager.Instance.GetMonitors();
            foreach (var monitor in monitors)
            {
                MonitorBarEntityViewModel monitorEntityViewModel = new MonitorBarEntityViewModel(monitor);

                Monitors.Add(monitorEntityViewModel);
            }

            SelectedMonitor = Monitors[0];

            StartWithInterval(Config.ScreenPeriod, NextMonitor);
        }
    }
}
