using System;
using System.Globalization;
using System.Windows.Data;

namespace SerialMonitoring.Converters
{
    class FloatPaddingConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d = System.Convert.ToDouble(value);

            return $"{d:F2}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
