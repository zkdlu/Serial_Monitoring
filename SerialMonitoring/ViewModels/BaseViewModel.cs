using SerialMonitoring.Common;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace SerialMonitoring.ViewModels
{
    class BaseViewModel : Notifier
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Action action;
        public BaseViewModel()
        {
        }

        public void StartWithInterval(int interval, Action action)
        {
            this.action = action;

            timer.Interval = TimeSpan.FromMilliseconds(interval);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            action.Invoke();
        }
    }
}
