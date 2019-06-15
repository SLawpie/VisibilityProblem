using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using VisibilityProblem.ViewModels;

namespace VisibilityProblem.Tools
{
    class ChangeVisibility
    {
        public void Change()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TargetButton.Visibility = Visibility.Visible;

                }
            }

        }


        public void Change10Times()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                Application.Current.Dispatcher.Invoke( delegate
                    {
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window.GetType() == typeof(MainWindow))
                            {
                                (window as MainWindow).TargetButton.Visibility = Visibility.Visible;
                            }
                        }
                    }
                 );

                Thread.Sleep(1000);

                Application.Current.Dispatcher.Invoke( delegate
                    {
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window.GetType() == typeof(MainWindow))
                            {
                                (window as MainWindow).TargetButton.Visibility = Visibility.Hidden;
                            }

                        }
                    }
                );

            };
        }

    }
}
