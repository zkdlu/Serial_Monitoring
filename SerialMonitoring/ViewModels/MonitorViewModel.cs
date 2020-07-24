using GalaSoft.MvvmLight.Command;
using SerialMonitoring.Common;
using SerialMonitoring.Models;
using SerialMonitoring.ViewModels.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace SerialMonitoring.ViewModels
{
    class MonitorViewModel : BaseViewModel
    {
        public IList<MonitorEntityViewModel> Monitors { get; } = new List<MonitorEntityViewModel>();

        private ICommand nextMonitorCommand;
        public ICommand NextMonitorCommand
        {
            get
            {
                if (nextMonitorCommand == null)
                {
                    nextMonitorCommand = new RelayCommand(NextMonitor);
                }

                return nextMonitorCommand;
            }
        }

        private int currentIndex;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                currentIndex = value;
                OnRaiseProperty(nameof(CurrentIndex));
            }
        }

        private MonitorEntityViewModel selectedMonitor;
        public MonitorEntityViewModel SelectedMonitor
        {
            get { return selectedMonitor; }
            set
            {
                selectedMonitor = value;
                OnRaiseProperty(nameof(SelectedMonitor));
            }
        }

        public int MonitorCount
        {
            get { return Monitors.Count; }
        }

        public MonitorViewModel()
        {
            //var monitors = ChannelManager.Instance.GetMonitors();
            //foreach (var monitor in monitors)
            //{
            //    MonitorEntityViewModel monitorEntityViewModel = new MonitorEntityViewModel(monitor);

            //    Monitors.Add(monitorEntityViewModel);
            //}

            //SelectedMonitor = Monitors[0];

            //StartWithInterval(Config.ScreenPeriod, NextMonitor);
        }

        protected void NextMonitor()
        {
            CurrentIndex = (CurrentIndex + 1) % MonitorCount;
            SelectedMonitor = Monitors[CurrentIndex];
        }
    }
}
