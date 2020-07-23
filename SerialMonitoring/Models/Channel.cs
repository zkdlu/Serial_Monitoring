using System.Windows.Media;

namespace SerialMonitoring.Models
{
    public class Channel
    {
        public string Name
        {
            get;
            set;
        }

        public string SubName
        {
            get;
            set;
        }

        public Brush Rrb
        {
            get;
            set;
        }

        public double Max
        {
            get;
            set;
        }

        public double AlertLimit
        {
            get;
            set;
        }

        public string Unit
        {
            get;
            set;
        }
    }
}
