using SerialMonitoring.Common;
using SerialMonitoring.Models;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace SerialMonitoring.ViewModels
{
    class MonitorViewModel : BaseViewModel
    {
        public IList<Monitor> Monitors { get; }

        public MonitorViewModel()
        {
            Monitors = ChannelManager.Instance.GetMonitors();
        }
    }
}
