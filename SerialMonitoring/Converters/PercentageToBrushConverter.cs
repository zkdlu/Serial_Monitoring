using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace SerialMonitoring.Converters
{
    class PercentageToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2)
            {
                if (values[0] is double percentage
                     && values[1] is double alertLimit)
                {
                    return percentage * 100 < alertLimit ? Brushes.Red : Brushes.Black;
                }
            }

            return Brushes.Black;
        }        

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
