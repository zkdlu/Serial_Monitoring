
using System.Collections.Generic;

namespace SerialMonitoring.Models
{
    public class Monitor
    {
        private readonly IList<Channel> channels = new List<Channel>();

        public IList<Channel> Channels
        {
            get
            {
                return channels;
            }
        }
    }
}
