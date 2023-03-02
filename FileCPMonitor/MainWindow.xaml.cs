using System;
using System.Windows;
using System.Windows.Forms;

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

        


        //鼠标单击
        private void notifyIcon_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visibility == Visibility.Visible)
                {
                    this.Visibility = Visibility.Hidden;
                }
                else
                {
                    this.Visibility = Visibility.Visible;
                    this.Activate();
                }
            }
        }


        //窗口发生移动时会触发
        private void SysTray_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.Visibility = Visibility.Hidden;
            }
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

        //选择退出时询问
        private void exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show("sure to exit?",
                                               "application",
                                                MessageBoxButton.YesNo,
                                                MessageBoxImage.Question,
                                                MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
