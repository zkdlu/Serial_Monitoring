using SerialMonitoring.Models;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SerialMonitoring.Common
{
    public class ChannelManager
    {
        public static ChannelManager Instance { get; } = new ChannelManager();

        public IList<Channel> Channels { get; } = new List<Channel>();

        public IList<Monitor> GetMonitors()
        {
            IList<Monitor> monitors = new List<Monitor>();

            int channelCount = Channels.Count;
            int monitorCount = (channelCount / 6) + 1;

            for (int i = 0; i < monitorCount; i++)
            {
                monitors.Add(new Monitor
                {
                    Width = Config.ScreenWidth,
                    Height = Config.ScreenHeight
                });
            }
            
            for (int i = 0; i < Channels.Count; i++)
            {
                int monitorIndex = i / 6;

                monitors[monitorIndex].Channels.Add(Channels[i]);
            }

            return monitors;
        }
    }
}
