using SerialMonitoring.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace SerialMonitoring.Common
{
    public static class Config
    {
        private static readonly string Config_Name = $"{Environment.CurrentDirectory}/config.txt";
        private static readonly string env_Name = $"{Environment.CurrentDirectory}/env.ini";

        public static string Title { get; set; }
        public static int Period { get; set; }
        public static bool IsMute { get; set; }
        public static bool IsModeFirst { get; set; }

        public static void SetEnvIni()
        {
            using (FileStream file = new FileStream(env_Name,
                FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(file))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] elems = line.Replace(" ", "").Split('=');
                    try
                    {
                        if (string.Compare(elems[0], "title", true) == 0)
                        {
                            Title = elems[1];
                        }
                        else if (string.Compare(elems[0], "nextScrPeriod ", true) == 0)
                        {
                            Period = int.Parse(elems[1]);
                        }
                        else if (string.Compare(elems[0], "mute", true) == 0)
                        {
                            IsMute = bool.Parse(elems[1]);
                        }
                        else if (string.Compare(elems[0], "mode1", true) == 0)
                        {
                            IsModeFirst = bool.Parse(elems[1]);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("env.ini Error");
                        Application.Current.Shutdown();
                    }
                }
            }
        }

        public static List<Channel> Read()
        {
            var result = new List<Channel>();

            using (FileStream file = new FileStream(Config_Name,
                FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(file))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] elems = line.Replace(" ", "").Split(',');
                    try
                    {
                        Channel channel = new Channel
                        {
                            Name = elems[0],
                            SubName = elems[1],
                            Rgb = new BrushConverter().ConvertFromString(elems[2]) as SolidColorBrush,
                            Max = int.Parse(elems[3]),
                            AlertLimit = int.Parse(elems[4]),
                            Unit = elems[5]
                        };

                        result.Add(channel);
                    }
                    catch
                    {
                        MessageBox.Show("Config.txt Error");
                        Application.Current.Shutdown();
                    }
                }
            }

            return result;
        }
    }
}
