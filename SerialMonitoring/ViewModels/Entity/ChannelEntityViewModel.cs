using SerialMonitoring.Models;

namespace SerialMonitoring.ViewModels.Entity
{
    class ChannelEntityViewModel : BaseViewModel
    {
        public Channel Channel { get; }

        public ChannelEntityViewModel(Channel channel)
        {
            Channel = channel;
        }
    }
}
