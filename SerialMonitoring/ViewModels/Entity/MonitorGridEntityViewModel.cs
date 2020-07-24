using SerialMonitoring.Models;

namespace SerialMonitoring.ViewModels.Entity
{
    class MonitorGridEntityViewModel : MonitorEntityViewModel
    {
        public MonitorGridEntityViewModel(Monitor monitor) : base(monitor)
        {
            foreach (var channel in Monitor.Channels)
            {
                Channels.Add(new ChannelGridEntityViewModel(channel));
            }
        }
    }
}
