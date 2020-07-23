
using System.Collections.Generic;

namespace SerialMonitoring.Models
{
    public class Monitor
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public IList<Channel> Channels { get; } = new List<Channel>();
    }
}
