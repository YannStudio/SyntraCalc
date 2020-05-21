using System;
using System.Globalization;
using System.Windows.Data;

namespace SyntraCalc.UI.WPF.Converters
{
    public class StringToImageSourceConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return value;
            }

            return new Uri($"../../Assets/{value.ToString()}.png", UriKind.Relative);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

