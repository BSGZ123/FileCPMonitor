using System.Windows;
using System.Windows.Forms;

namespace FileCPMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon notifyIcon = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitialTray()
        {
            //隐藏主窗体
            this.Visibility = Visibility.Hidden;

            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipText = "FileCPMonitor running ...";
            notifyIcon.Text = "FileCPMonitor";
            notifyIcon.Icon = new System.Drawing.Icon("");
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
