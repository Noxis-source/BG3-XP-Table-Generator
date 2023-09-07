using DevExpress.Xpf.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace BG3_XP_Table_Generator.Converters
{
    public class ProgressionToGradientConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is ObservableCollection<XPDataRecord> collection) {
                var colorStart = (Color)ColorConverter.ConvertFromString("#FF1D691D");
                var colorEnd = (Color)ColorConverter.ConvertFromString("#FF8A631A");

                var rStart = colorStart.R;
                var gStart = colorStart.G;
                var bStart = colorStart.B;

                var rEnd = colorEnd.R;
                var gEnd = colorEnd.G;
                var bEnd = colorEnd.B;

                return new CustomPalette(collection.Select(x => {
                    var rAverage = rStart + ((rEnd - rStart) * collection.IndexOf(x) / collection.Count);
                    var gAverage = gStart + ((gEnd - gStart) * collection.IndexOf(x) / collection.Count);
                    var bAverage = bStart + ((bEnd - bStart) * collection.IndexOf(x) / collection.Count);

                    return Color.FromRgb((byte)rAverage, (byte)gAverage, (byte)bAverage);
                }).ToArray());
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}
