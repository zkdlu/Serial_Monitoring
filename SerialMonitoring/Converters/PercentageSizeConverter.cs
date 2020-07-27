using System;
using System.Globalization;
using System.Windows.Data;

namespace SerialMonitoring.Converters
{
    class PercentageSizeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2)
            {
                if (values[0] is double percentage
                     && values[1] is double actualSize)
                {
                    return percentage * actualSize;
                }
            }

            return 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
