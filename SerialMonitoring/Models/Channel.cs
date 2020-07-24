using SerialMonitoring.Common;
using System.Windows.Media;

namespace SerialMonitoring.Models
{
    public class Channel : Notifier
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

        public Brush Rgb
        {
            get;
            set;
        }

        private double val;
        public double Value
        {
            get { return val; }
            set
            {
                val = value;
                OnRaiseProperty(nameof(Value));
                OnRaiseProperty(nameof(Percentage));
            }
        }

        public double Max
        {
            get;
            set;
        }

        public double Percentage
        {
            get
            {
                return Value / Max;
            }
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
