using SerialMonitoring.Common;
using SerialMonitoring.ViewModels.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialMonitoring.ViewModels
{
    class MonitorGridViewModel : MonitorViewModel
    {
        public MonitorGridViewModel()
        {
            var monitors = ChannelManager.Instance.GetMonitors();
            foreach (var monitor in monitors)
            {
                MonitorGridEntityViewModel monitorEntityViewModel = new MonitorGridEntityViewModel(monitor);

                Monitors.Add(monitorEntityViewModel);
            }

            SelectedMonitor = Monitors[0];

            StartWithInterval(Config.ScreenPeriod, NextMonitor);
        }
    }
}
