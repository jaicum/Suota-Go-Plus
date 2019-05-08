﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace suota_pgp
{
    public class ScanStateToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result;
            if (value is State state)
            {
                result = (state == State.Scanning);
            }
            else
            {
                throw new ArgumentException("State expected", "value");
            }

            if (parameter is string inverse)
            {
                if (inverse == "inverse")
                {
                    result = !result;
                }
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Not needed
            throw new NotImplementedException();
        }
    }
}
