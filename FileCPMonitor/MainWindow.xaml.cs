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

namespace FileCPMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        //后台驻留逻辑 默认是后台驻留的
        public void MenuitemDone(object sender, RoutedEventArgs e)
        {
            if (imgVisible.Visibility == Visibility.Visible)
            {
                imgVisible.Visibility = Visibility.Hidden;
            }
            else
            {
                imgVisible.Visibility = Visibility.Visible;
            }
            
        }
    }
}
