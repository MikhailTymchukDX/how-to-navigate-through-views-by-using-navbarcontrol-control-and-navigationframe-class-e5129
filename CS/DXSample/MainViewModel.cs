using DevExpress.Xpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXSample {
    public class MainViewModel : ViewModelBase {
        public ICommand OnViewLoadedCommand { get; private set; }
        public ICommand GoToUserControl1Command { get; private set; }
        public ICommand GoToUserControl2Command { get; private set; }
        public ICommand GoToUserControl3Command { get; private set; }
        public MainViewModel() {
            OnViewLoadedCommand = new DelegateCommand(OnNavigateDetailsCommandExecute);
            GoToUserControl1Command = new DelegateCommand(GoToUserControl1CommandExecute);
            GoToUserControl2Command = new DelegateCommand(GoToUserControl2CommandExecute);
            GoToUserControl3Command = new DelegateCommand(GoToUserControl3CommandExecute);

        }
        void OnNavigateDetailsCommandExecute() {
            //Navigate to the HomeView.
            ServiceContainer.GetService<INavigationService>().Navigate("HomeView", null, this);
        }
        private void GoToUserControl1CommandExecute() {
            ServiceContainer.GetService<INavigationService>().Navigate("UserControl1", null, this);
        }
        private void GoToUserControl2CommandExecute() {
            ServiceContainer.GetService<INavigationService>().Navigate("UserControl2", null, this);
        }
        private void GoToUserControl3CommandExecute() {
            ServiceContainer.GetService<INavigationService>().Navigate("UserControl3", null, this);
        }
    }
}
