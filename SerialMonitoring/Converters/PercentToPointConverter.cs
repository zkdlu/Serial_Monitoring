using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace SerialMonitoring.Converters
{
    class PercentToPointConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d && bool.TryParse(parameter.ToString(), out bool isVertical))
            {
                if (isVertical)
                {
                    return new Point(0, d);
                }
                else
                {
                    return new Point(d, 0);
                }
            }

            return new Point();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
