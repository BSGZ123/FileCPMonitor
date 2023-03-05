using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FileCPMonitor.ViewModel
{
    public class NotifyIconViewModel
    {
        //如果窗口没显示，就显示窗口
        public ICommand ShowWindowCommand
        {
            get
            {
                return new DelegateCommand
                {
                    CanExecuteFunc = () => Application.Current.MainWindow == null,
                    CommandAction= () =>
                    {
                        Application.Current.MainWindow= new MainWindow();
                        Application.Current.MainWindow.Show();
                    }
                };
            }
        }

        //隐藏窗口
        public ICommand HideWindowCommand
        {
            get
            {
                return new DelegateCommand
                {
                    CommandAction = () => Application.Current.MainWindow.Close(),
                    CanExecuteFunc = () => Application.Current.MainWindow != null
                };
            }
        }

        //退出软件
        public ICommand ExitApplicationCommand
        {
            get { return new DelegateCommand { CommandAction = () => Application.Current.Shutdown() }; }
        }

    }
}
