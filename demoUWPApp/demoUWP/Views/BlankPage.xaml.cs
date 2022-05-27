using System;

using demoUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace demoUWP.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            InitializeComponent();
        }

        private BlankViewModel ViewModel
        {
            get { return DataContext as BlankViewModel; }
        }
    }
}
