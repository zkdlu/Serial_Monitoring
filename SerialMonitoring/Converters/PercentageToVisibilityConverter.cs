using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SerialMonitoring.Converters
{
    class PercentageToVisibilityConverter : IMultiValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if (value is double percentage && 
        //            parameter is double alertLimit)
        //    {
        //        return percentage < alertLimit ? Visibility.Visible : Visibility.Collapsed;
        //    }

        //    return Visibility.Collapsed;
        //}

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2)
            {
                if (values[0] is double percentage
                     && values[1] is double alertLimit)
                {
                    return percentage * 100 < alertLimit ? Visibility.Visible : Visibility.Collapsed;
                }
            }

            return Visibility.Collapsed;
        }        

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
