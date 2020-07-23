using System.ComponentModel;

namespace SerialMonitoring.Common
{
    class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnRaiseProperty(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));                
        }
    }
}
