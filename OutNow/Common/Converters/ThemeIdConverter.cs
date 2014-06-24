using OutNow.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace OutNow.Common.Converters
{
    public class ThemeIdConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            if (targetType != typeof(string))
                throw new InvalidOperationException("The target must be a string");


            return null;// ThemeDatas.ThemesID[(int)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            throw new NotSupportedException();
        }
    }
}