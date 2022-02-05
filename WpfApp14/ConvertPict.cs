using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp14
{
    class ConvertPict : IValueConverter
    {
        public object Convert(object value, Type targetType, object paraeter, CultureInfo culture)
        {
            if (((int)value) == 1)
            {
                return "Pict/1.jpg";
            }
            return "Pict/2.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
