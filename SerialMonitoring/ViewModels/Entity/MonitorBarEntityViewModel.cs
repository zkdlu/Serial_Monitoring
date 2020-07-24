using SerialMonitoring.Models;

namespace SerialMonitoring.ViewModels.Entity
{
    class MonitorBarEntityViewModel : MonitorEntityViewModel
    {
        public MonitorBarEntityViewModel(Monitor monitor) : base(monitor)
        {
            foreach (var channel in Monitor.Channels)
            {
                Channels.Add(new ChannelBarEntityViewModel(channel));
            }
        }
    }
}
