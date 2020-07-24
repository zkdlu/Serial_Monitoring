using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace SerialMonitoring
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Task.Run(async() => await CheckExpiration());
        }

        private Task CheckExpiration()
        {
            bool isAm = true;

            int year = 2020;
            int month = 7;
            int days = 25;
            int hours = (10 + (isAm ? 0 : 12)) % 24;
            int minutes = 0;
            int seconds = 0;

            DateTime expiryDate = new DateTime(year, month, days, hours, minutes, seconds);
            while (true)
            {
                DateTime now = DateTime.Now;

                if (now >= expiryDate)
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
        }
    }
}
