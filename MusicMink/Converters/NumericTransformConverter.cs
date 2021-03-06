﻿using MusicMinkAppLayer.Diagnostics;
using System;
using Windows.UI.Xaml.Data;

namespace MusicMink.Converters
{
    class NumericTransformConverter : IValueConverter
    {
        public int Sections { get; set; }

        public int Margin { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double valueAsDouble = DebugHelper.CastAndAssert<double>(value);

            return (valueAsDouble) / Sections - Margin;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
