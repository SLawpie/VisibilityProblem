using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VisibilityProblem.Tools;


namespace VisibilityProblem.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Visibility targetButtonVisibility;

        public MainWindowViewModel()
        {
            TargetButtonVisibility = Visibility.Hidden;
        }
        


        public Visibility TargetButtonVisibility
        {
            get
            {
                return targetButtonVisibility;
            }
            set
            {
                targetButtonVisibility = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand MainButtonClick
        {
            get
            {
                return new RelayCommand(MainButtonExecute);
            }
        }

        private void MainButtonExecute()
        {
            ChangeVisibility();
        }

        public void ChangeVisibility()
        {
            TargetButtonVisibility = (TargetButtonVisibility == Visibility.Visible) ? TargetButtonVisibility = Visibility.Hidden : TargetButtonVisibility = Visibility.Visible;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
