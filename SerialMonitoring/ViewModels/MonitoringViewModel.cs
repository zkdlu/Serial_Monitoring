using System;
using System.Windows;

namespace SerialMonitoring.ViewModels
{
    class MonitoringViewModel : BaseViewModel
    {
        private int selectedModeFirst;
        public int SelectedModeFirst
        {
            get { return selectedModeFirst; }
            set
            {
                selectedModeFirst = value;
                OnRaiseProperty(nameof(SelectedModeFirst));
            }
        }

        public MonitoringViewModel()
        {
            Mediator.Register("ChangeView", OnChangeView);
        }

        private void OnChangeView(object showFirst)
        {
            bool isFirst = (bool)showFirst;

            SelectedModeFirst = isFirst ? 0 : 1;
        }
    }
}
