using GalaSoft.MvvmLight.Command;
using SerialMonitoring.Common;
using System;
using System.Configuration;
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
            Title = Config.Title;
            IsMute = Config.IsMute;
            IsModeFirst = Config.IsModeFirst;

            StartWithInterval(10, SetCurrentTime);
        }

        private void SetCurrentTime()
        {
            Task.Run(() =>
            {
                DateTime dateTime = DateTime.Now;

                string result = dateTime.ToString("yyyy-MM-dd hh:mm:ss");
                Now = result;
            });
        }
    }
}
