using SerialMonitoring.Models;

namespace SerialMonitoring.Common
{
    public static class Config
    {
        public static string Title { get; private set; }
        public static int Period { get; private set; }
        public static bool IsMute { get; private set; }
        public static bool IsModeFirst { get; private set; }

        public static void SetEnvIni()
        {
            Title = "한국수자원연구소 가스 모니터링 시스템 v1.0";
            Period = 3;
            IsMute = false;
            IsModeFirst = true;
        }

        public static Channel Read()
        {
            return null;
        }
    }
}
