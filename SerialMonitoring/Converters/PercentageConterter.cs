using System;
using System.Globalization;
using System.Windows.Data;

namespace SerialMonitoring.Converters
{
    public class PercentageConterter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
            {
                d = Math.Round(d * 100, 2);
                return $"{d:F2} %";
            }
            return "Convert Error";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
