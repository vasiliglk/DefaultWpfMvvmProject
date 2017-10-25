using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Logic.UI.ViewModels
{
    public class DefaultMainViewModel : ViewModelBase
    {
        #region Commands
        public ICommand CloseCommand { get; }
        public ICommand MoveCommand { get; }
        #endregion

        public DefaultMainViewModel()
        {
            CloseCommand = new RelayCommand(() => { Application.Current.MainWindow?.Close(); });
            MoveCommand = new RelayCommand(() => { Application.Current.MainWindow?.DragMove(); });
        }
    }
}
