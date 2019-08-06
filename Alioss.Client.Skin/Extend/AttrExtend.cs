using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Alioss.Client.Skin.Extend
{
    public class AttrExtend: DependencyObject
    {
        public static object GetSourceAttr(DependencyObject obj)
        {
            return (object)obj.GetValue(SourceAttrProperty);
        }

        public static void SetSourceAttr(DependencyObject obj, object value)
        {
            obj.SetValue(SourceAttrProperty, value);
        }

        /// <summary>
        /// 附加图片
        /// </summary>
        public static readonly DependencyProperty SourceAttrProperty =
            DependencyProperty.RegisterAttached("SourceAttr", typeof(object), typeof(AttrExtend), new PropertyMetadata(null));

        /// <summary>
        /// 字体大小
        /// </summary>
        public static readonly DependencyProperty TitleFontSizeProperty =
           DependencyProperty.RegisterAttached("TitleFontSize", typeof(int), typeof(AttrExtend), new PropertyMetadata(null));

        public static int GetTitleFontSize(DependencyObject obj)
        {
            return (int)obj.GetValue(TitleFontSizeProperty);
        }
    }
}
