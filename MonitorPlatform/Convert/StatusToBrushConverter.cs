﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace MonitorPlatform.Convert
{
    
    public class StatusToBrushConverter : IValueConverter
    {
#if NETFX_CORE

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return InternalConvert(value, targetType, parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

#else
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return InternalConvert(value, targetType, parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

#endif

        public object InternalConvert(object value, Type targetType, object parameter)
        {
            if (value == null)
            {
                return null;
            }

            string status = value.ToString();
            SolidColorBrush scb = new SolidColorBrush();
            switch (status as string)
            {
                case "1":
                    scb.Color = Colors.Green;
                    return scb;
                case "2":
                    scb.Color = Colors.Yellow;
                    return scb;
                case "3":
                    scb.Color = Colors.Red;
                    return scb;
               
                default:
                    return null;
            }
        }
    }
}
