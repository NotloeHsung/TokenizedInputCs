using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TokenizedTag.Converter
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class InvertedBoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool enabled = (bool)value;
            if (enabled)
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}