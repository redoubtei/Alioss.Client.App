using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alioss.Client.App.View
{
    /// <summary>
    /// User3.xaml 的交互逻辑
    /// </summary>
    public partial class User3 : UserControl
    {
        public User3()
        {
            InitializeComponent();
        }

        public void initMenu()
        {

            //   menulist.DataContext ="";
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            //获取点击的对象
            Button button = sender as Button;
            if (button != null)
            { }
        }
    }
}
