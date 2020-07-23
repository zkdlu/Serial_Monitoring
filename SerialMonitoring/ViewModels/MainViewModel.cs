using GalaSoft.MvvmLight.Command;
using SerialMonitoring.Common;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SerialMonitoring.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private ICommand modeChangeCommand;
        public ICommand ModeChangeCommand
        {
            get
            {
                if (modeChangeCommand == null)
                {
                    modeChangeCommand = new RelayCommand(() =>
                    {
                        Mediator.NotifyColleagues("ChangeView", IsModeFirst);
                    });
                }

                return modeChangeCommand;
            }
        }

        private string now;
        public string Now
        {
            get { return now; }
            set
            {
                now = value;
                OnRaiseProperty(nameof(Now));
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnRaiseProperty(nameof(Title));
            }
        }

        private int period;
        public int Period
        {
            get { return period; }
            set
            {
                period = value;
                OnRaiseProperty(nameof(Period));
            }
        }

        private bool isMute;
        public bool IsMute
        {
            get { return isMute; }
            set
            {
                isMute = value;
                OnRaiseProperty(nameof(IsMute));

                Config.IsMute = isMute;
            }
        }

        private bool isModeFirst;
        public bool IsModeFirst
        {
            get { return isModeFirst; }
            set
            {
                isModeFirst = value;
                OnRaiseProperty(nameof(IsModeFirst));

                Config.IsModeFirst = isModeFirst;
            }
        }

        public MainViewModel()
        {
            Config.Read();
            Config.SetEnvIni();

            Title = Config.Title;
            Period = Config.Period;
            IsMute = Config.IsMute;
            IsModeFirst = Config.IsModeFirst;

            Task.Run(async() =>
            {
                while (true)
                {
                    string result = await GetCurrentTime();
                    Now = result;
                }
            });
        }

        private async Task<string> GetCurrentTime()
        {
            var task = new Task<string>(() =>
            {
                DateTime dateTime = DateTime.Now;

                return dateTime.ToString("yyyy-MM-dd hh:mm:ss");
            });
            task.Start();

            await task;

            return task.Result;
        }
    }
}
