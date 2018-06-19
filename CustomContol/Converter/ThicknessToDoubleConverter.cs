using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Tasks;
using System.Windows;
using System.Windows.Data;

namespace CustomContol.Converter
{
    /// <summary>
    /// 获取Thickness固定值double
    /// </summary>
    public class ThicknessToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var thickness = (Thickness)value;
            return thickness.Left;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
