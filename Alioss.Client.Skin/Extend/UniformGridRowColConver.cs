using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Alioss.Client.Skin.Extend
{
    class UniformGridRowColConver : IValueConverter
    {
        public UniformGridRowColConver()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return 0;
            }
            int i = (value as IList).Count;
            int row = i / 3;
            int row_s = i % 3;
            if (row_s > 0)
            {
                return row + 1;
            }
            else
            {
                return row;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
