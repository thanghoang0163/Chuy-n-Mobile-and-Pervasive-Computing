using System;

using demoUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace demoUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        private void btn1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            frame.Navigate(typeof(Page1));
        }

        private void btn2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            frame.Navigate(typeof(Page2));
        }

        private void btn3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            frame.Navigate(typeof(Page3));
        }

        private void back_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        private void next_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (frame.CanGoForward)
            {
                frame.GoForward();
            }
        }
    }
}
