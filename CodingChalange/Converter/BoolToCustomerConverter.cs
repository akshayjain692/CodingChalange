using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CodingChalange.Converter
{
    public class BoolToCustomerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var _value = value is bool ? (bool)value : false;
            string name;
            if (_value)
                name = "Welcome privileged user";
            else
                name = "Welcome regular user";

            return name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
