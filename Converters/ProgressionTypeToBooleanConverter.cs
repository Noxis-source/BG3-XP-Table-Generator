using GeneratorData;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace BG3_XP_Table_Generator.Converters {
    public class ProgressionTypeToBooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return value is ProgressionType t && t == ProgressionType.Custom;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
