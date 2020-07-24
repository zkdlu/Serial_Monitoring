using SerialMonitoring.Models;
using SerialMonitoring.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Threading;

namespace SerialMonitoring.Common
{
    public class ChannelManager
    {
        public static ChannelManager Instance { get; } = new ChannelManager();

        public IList<Channel> Channels { get; } = new List<Channel>();

        public IList<Monitor> GetMonitors()
        {
            IList<Monitor> monitors = new List<Monitor>();

            int channelCount = Channels.Count;
            int monitorCount = ((channelCount - 1) / 6) + 1;
            
            for (int i = 0; i < monitorCount; i++)
            {
                monitors.Add(new Monitor
                {
                    Width = Config.ScreenWidth,
                    Height = Config.ScreenHeight
                });
            }
            
            for (int i = 0; i < Channels.Count; i++)
            {
                int monitorIndex = i / 6;

                monitors[monitorIndex].Channels.Add(Channels[i]);
            }

            return monitors;
        }

        private static Random random = new Random();
        private static DispatcherTimer timer = new DispatcherTimer();

        static ChannelManager()
        {
            timer.Interval = TimeSpan.FromMilliseconds(800);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            TestSerialData();
        }

        private static void TestSerialData()
        {
            Task.Run(() => CheckAlert());

            SerialPacket packet = SerialManager.Instnace.Receive();

            foreach (var channel in Instance.Channels)
            {
                if (random.NextDouble() <= 0.3)
                {
                    channel.Value = random.Next(1, (int)channel.Max);
                }
            }
        }

        private static bool playing = false;
        private static async Task CheckAlert()
        {
            var channels = Instance.Channels.Where(c => c.Percentage * 100 < c.AlertLimit);

            foreach (var channel in channels)
            {
                if (channel.Percentage * 100 < channel.AlertLimit)
                {
                    if (!Config.IsMute && playing == false)
                    {
                        await Alert();
                    }

                    break;
                }
            }
        }

        private static async Task Alert()
        {
            SoundPlayer soundPlayer = new SoundPlayer($"{Environment.CurrentDirectory}/alert.wav");

            await Task.Run(() =>
            {
                playing = true;
                soundPlayer.PlaySync();
                soundPlayer.Stop();
                playing = false;
            });
        }
    }
}
