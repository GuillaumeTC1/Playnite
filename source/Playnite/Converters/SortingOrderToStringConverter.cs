using Playnite.SDK.Models;
using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite.Converters
{
    public class SortingOrderToStringConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var order = (SortOrder)value;
            return order.GetDescription();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
