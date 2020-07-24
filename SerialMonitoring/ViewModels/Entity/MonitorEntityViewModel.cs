using SerialMonitoring.Models;
using System.Collections.Generic;

namespace SerialMonitoring.ViewModels.Entity
{
    class MonitorEntityViewModel : BaseViewModel
    {
        public Monitor Monitor { get; }

        public IList<ChannelEntityViewModel> Channels { get; } = new List<ChannelEntityViewModel>();

        public MonitorEntityViewModel(Monitor monitor)
        {
            Monitor = monitor;
        }
    }
}
